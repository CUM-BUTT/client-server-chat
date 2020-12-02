using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public class Adress
    {
        public int port;
        public string ip;
        public IPEndPoint ip_point;
        public Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Adress(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
            ip_point = new IPEndPoint(IPAddress.Parse(ip), port);
        }
        public Adress()
        {

        }
        public void BindListen(int connection_count)
        {
            socket.Bind(ip_point);
            socket.Listen(connection_count);
        }
        public void Connect()
        {
            socket.Connect(ip_point);
        }
    }
}
