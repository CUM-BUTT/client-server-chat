using client_server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client
{
    public class ClientForWindow : SafetyLink
    {
        List<Thread> threads = new List<Thread>();
        public ClientForWindow()
        {
            connection_failed_event += Reconnect;
            threads.Add(new Thread(WaitForMessage));
        }

        private void Reconnect(Exception exeption, Link sender)
        {
            AskServer();
        }

        public void Run()
        {
            AskServer();
            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());
        }
    }
}
