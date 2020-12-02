using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client_server;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Server();
            s.Run();
        }
    }
}
