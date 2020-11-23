using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public class SafetyLink : Link
    {
        public delegate void SomeExeption(Exception exeption, Link sender);
        public event SomeExeption connection_broken_event;
        public event SomeExeption decoding_error_event;
        public event SomeExeption sending_error_event;
        public event SomeExeption connection_failed_event;//as client
        public event SomeExeption accept_error_event;//as server

        public delegate void SomeSocketEvent(Link sender);
        public event SomeSocketEvent accept_success_event;

        public delegate void GettingMessage(Message message, Link sender);
        public event GettingMessage message_event;

        public override void AskServer()
        {
            try
            {
                base.AskServer();
            }
            catch (Exception e)
            {
                connection_failed_event?.Invoke(e, this);
            }
        }
        public override void Send(Message message)
        {
            try
            {
                base.Send(message);
            }
            catch (Exception e)
            {
                this.sending_error_event?.Invoke(e, this);
                throw e;
            }     
        }
        public override void WaitForConnection()
        {
            try
            {
                base.WaitForConnection();
                this.accept_success_event?.Invoke(this);
            }
            catch (Exception e)
            {
                this.accept_error_event?.Invoke(e, this);
                throw e;
            }
        }
        public override void WaitForMessage()
        {
            try
            {
                base.WaitForMessage();
            }
            catch (Exception e)
            {
                this.connection_broken_event?.Invoke(e, this);
                //throw e;
            }
        }
        public override Message BytesToMessage(byte[] message)
        {
            try
            {
                var mes = base.BytesToMessage(message);
                this.message_event?.Invoke(mes, this);
            }
            catch (Exception e)
            {
                this.decoding_error_event?.Invoke(e, this);
                //throw e;
            }
            return null;
        }
    }
}
