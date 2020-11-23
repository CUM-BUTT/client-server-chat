using client_server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class ServerLink : SafetyLink
    {
        int connection_count = 10;
        public ServerLink ()
        {
            //message_event += GetMessage;

            me = new Adress ( "127.0.0.1", 5000 );
            another = new Adress();
        }

        public void Run()
        {
            //me.BindThenListen(connection_count);
            WaitForConnection();
            WaitForMessage();
        }

        private void GetMessage(Message message, Link sender)
        {
            Console.WriteLine(message.message);
            Send(message);
        }  
    }
}
