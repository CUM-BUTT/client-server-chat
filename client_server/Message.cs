using System;
using System.Net.Sockets;

namespace client_server
{
    [Serializable]
    public class Message
    {
        //public Socket sender;
        public string sender;
        public string message;
    }
}