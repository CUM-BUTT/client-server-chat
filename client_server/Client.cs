using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client_server
{
    public class Client : Base
    {
        public override void Run()
        {

            another.Connect();
            base.Run();
        }
    }
}
