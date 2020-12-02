using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using static client_server.IBase;

namespace client_server
{
    public class Base : IBase
    {
        public event SomeEvent get_message_event;
        public event SomeEvent error_event;
        public event SomeEvent disconnect_event;

        public Adress another = new Adress();

        public virtual void Send(Message message)
        {
            another.socket.Send(message.MessageToBytes());
        }

        public virtual void Recv()
        {
            while (another.socket.Connected)
            {
                var stream = new MemoryStream();
                var received = new List<byte>();
                var data = new byte[256];
                do
                {
                    var bytes = another.socket.Receive(data);
                    data.ToList().ForEach(d => received.Add(d));
                }
                while (another.socket.Available > 0);

                if (received.Count > 0)
                {
                    try
                    {
                        var message = Message.BytesToMessage(received.ToArray());
                        get_message_event.Invoke(message, this);
                    }
                    catch (Exception e)
                    {
                        error_event?.Invoke(new Message { message = "decoding error" }, this);
                        throw e;
                    }  
                } 
            }
            disconnect_event.Invoke(new Message { message = "disconnected" }, this);
        }

        virtual public void Run()
        {
            var thread = new Thread(Recv);
            thread.Start();
        }
    }
}
