using client_server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client
{
    public class Client : SafetyLink
    {
        List<Thread> threads = new List<Thread>();
        string name = "";
        public Client()
        {
            this.me = new Adress("127.0.0.1", new Random().Next(5000, 10000));
            another = new Adress("127.0.0.1", 5000);


            connection_failed_event += Reconnect;
            message_event += GetMessage;
            threads.Add(new Thread(WaitForMessage));
            threads.Add(new Thread(Sending));
        }

        private void GetMessage(Message message, Link sender)
        {
            Console.WriteLine($"{message.sender}: {message.message}");
        }

        private void Reconnect(Exception exeption, Link sender)
        {
            Console.WriteLine(exeption.Message);
            AskServer();
        }

        public void Run()
        {
            AskServer();
            Console.WriteLine("input your name :");
            name = Console.ReadLine();
            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());
        }

        void Sending()
        {
            while (true)
            {
                var mes = Console.ReadLine();
                Send(new Message { message = mes, sender = name });
            }
        }

    }
}
