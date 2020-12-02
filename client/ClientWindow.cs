using client_server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class ClientWindow : Form
    {
        Client client = new Client();
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            var ip = textBox_ip.Text;
            var port = int.Parse(textBox_port.Text);
            client.another = new Adress(ip, port);
            client.get_message_event += GetMessage;
            new Thread(client.Run).Start();
        }

        private void GetMessage(client_server.Message message, Object sender)
        {
            var mes = $"\n{message.sender} :{message.message}\n" + System.Environment.NewLine;
            if (textBox_chat.InvokeRequired)
            {
                textBox_chat.Invoke(new Action<string>((s) => textBox_chat.AppendText(s)),mes);
            }
            else 
            {
                textBox_chat.AppendText(mes);
            }
        }

        void Send()
        {
            var message = new client_server.Message
            { sender = textBox_name.Text, message = textBox_input_freld.Text };
            client.Send(message);
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void textBox_input_freld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }
    }
}
