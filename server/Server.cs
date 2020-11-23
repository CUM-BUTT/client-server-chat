using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using client;
using client_server;

namespace server
{
    class Server
    {
        List<ServerLink> clients = new List<ServerLink>();
        Adress me;
        int connection_count = 10;


        public Server()
        {
            var host = Dns.GetHostName();
            var ip =   Dns.GetHostByName(host).AddressList[0].ToString();
            var port = 5000;
            Console.WriteLine($"{ip}:{port}");
            me = new Adress(ip, port);
            me.BindThenListen(connection_count);
        }

        public void Run()
        {
            BuildNewServerLink();
        }

        void BuildNewServerLink()
        {
            var server_link = new ServerLink();
            server_link.me = me;
            server_link.connection_broken_event += ClientDisconnected;
            server_link.connection_failed_event += ClientDisconnected;
            server_link.accept_success_event += AddClient;
            server_link.message_event += GetMessage;
            
            new Thread(server_link.Run).Start();
        }

        void GetMessage(Message message, Link link)
        {
            clients.ForEach(c => c.Send(message));
            Console.WriteLine($"{message.sender}: {message.message}");
        }
        void AddClient(Link link)
        {
            Console.WriteLine("add client");
            clients.Add(link as ServerLink);
            BuildNewServerLink();
        }
        void ClientDisconnected(Exception e, Link link)
        {
            Console.WriteLine(e.Message);
            clients.Remove(link as ServerLink);
            BuildNewServerLink();
        }
    }
}


