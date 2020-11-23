using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public class Link : ILink
    {
        public Adress me, another;

        //for serialization
        protected BinaryFormatter formatter = new BinaryFormatter();

        public virtual Message BytesToMessage(byte[] message)
        {
            var stream = new MemoryStream(message);
            return formatter.Deserialize(stream) as Message;
        }

        public virtual byte[] MessageToBytes(Message message)
        {
            var stream = new MemoryStream();
            formatter.Serialize(stream, message);
            return stream.ToArray();
        }

        public virtual void Send(Message message)
        {
            another.socket.Send(MessageToBytes(message));
        }

        public virtual void WaitForConnection()//as server
        {
            //this.me.Bind();
            //me.socket.Listen(1);
            another.socket = me.socket.Accept();
        }

        public virtual void WaitForMessage()
        {
            while (another.socket.Connected)
            {
                var stream = new MemoryStream();
                var received = new List<byte>();
                do
                {
                    var data = new byte[256];
                    var bytes = another.socket.Receive(data);
                    data.ToList().ForEach(d => received.Add(d));
                }
                while (another.socket.Available > 0);

                if (received.Count > 0)
                {
                    this.BytesToMessage(received.ToArray());
                } 
            }
        }

        public virtual void AskServer()//as client
        {
            another.socket.Connect(another.ip_point);
        }

        public virtual void GetMessage(Message message)
        {
            Console.WriteLine($"{message.sender} :{message.message}");
        }
    }
}
