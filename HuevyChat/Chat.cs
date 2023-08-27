using System;
using System.Linq;
using System.Windows.Forms;

namespace HueChat
{
    public partial class Chat : Form
    {

        Client client;
        string msgOld;
        System.Timers.Timer timer;

        public Chat(Client client)
        {
            this.client = client;
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Interval = 1;
            timer.Elapsed += (sender, ElapsedEventHandler) => { Updater(); };
            timer.Start();

        }

        private void Updater()
        {
            TextChat.Invoke(new Action(() => { if (client.getMSG() != msgOld) { TextChat.Text = TextChat.Text+ "\r\n" + client.getMSG(); } }));
            msgOld = client.getMSG();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (MessageUser.Text != "")
            {
                client.Writer(MessageUser.Text);
                MessageUser.Text = "";
            }
        }

        private void MessageUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (MessageUser.Text != "")
                {
                    client.Writer(MessageUser.Text);
                    MessageUser.Text = "";
                }
            }
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
            Environment.Exit(0);
        }
    }
}
