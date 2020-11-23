using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public interface ILink 
    {
        void WaitForConnection();
        void WaitForMessage();
        void AskServer();
        void Send(Message message);
        void GetMessage(Message message);

        Message BytesToMessage(byte[] message);
        byte[] MessageToBytes(Message message);
    }
}
