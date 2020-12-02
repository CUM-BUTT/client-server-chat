using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public class Server 
    {
        int connection_count = 10;
        Adress listen_socket = new Adress("127.0.0.1", 5000);
        List<Base> anothers = new List<Base>();
        public void Run()
        {
            Console.WriteLine($"{listen_socket.ip}:{listen_socket.port}");
            listen_socket.BindListen(connection_count);
            WaitForConnection();
        }
        void WaitForConnection()
        {
            while (true)
            {
                var another = new Base();
                another.another.socket = listen_socket.socket.Accept();
                Console.WriteLine("add client");
                another.get_message_event += GetMessage;
                another.disconnect_event += Disconnect;
                another.Run();
                anothers.Add(another);
            }
        }

        private void Disconnect(Message message, object sender)
        {
            Console.WriteLine(message.message);
            anothers.Remove(sender as Base);
        }

        private void GetMessage(Message message, object sender)
        {
            anothers.ForEach(another => another.Send(message));
        }
        
    }
}
