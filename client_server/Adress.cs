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
        public Adress(string ip=null, int port=-1)
        {
            this.ip = ip;
            this.port = port;
            if (ip != null)
            {
                ip_point = new IPEndPoint(IPAddress.Parse(ip), port);
            }
        }

        public void BindThenListen(int connected_count)
        {
         
            try
            {
                socket.Bind(ip_point);
                socket.Listen(connected_count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

    }
}
