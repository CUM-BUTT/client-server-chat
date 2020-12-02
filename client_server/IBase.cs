using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public interface IBase 
    {
        delegate void SomeEvent(Message message, object sender);

        void Send(Message message);
        void Recv();
        void Run();
    }
}
