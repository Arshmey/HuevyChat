using System;
using HueChat.ServerFiles;
using System.Windows.Forms;

namespace HueChat
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Server server = new Server(int.Parse(EnterPort.Text));
            new ServerChat(server, int.Parse(EnterPort.Text)).Show();
            Client client = new Client(EnterNick.Text, "localhost:" + EnterPort.Text);
            new Chat(client).Show();
            Visible = false;
        }

        private void bConncet_Click(object sender, EventArgs e)
        {
            if (EnterNick.Text != "")
            {
                Client client = new Client(EnterNick.Text, hostName.Text);
                new Chat(client).Show();
                Visible = false;
            }
        }
    }
}
