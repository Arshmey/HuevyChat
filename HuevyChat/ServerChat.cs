using System;
using HueChat.ServerFiles;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace HueChat
{
    public partial class ServerChat : Form
    {

        Server server;
        int PORT;
        NetworkStream logStream;
        

        public ServerChat(Server server, int PORT)
        {
            this.server = server;
            this.PORT = PORT;
            InitializeComponent();
            System.Timers.Timer time = new System.Timers.Timer();
            time.AutoReset = true;
            time.Elapsed += (sender, ElapsedEventHandler) => { UpdaterCount(); };
            time.Interval = 1;
            time.Start();
            new Thread(LogsUser).Start();
        }

        private void LogsUser()
        {
            TcpClient tcpClient = new TcpClient("localhost", PORT);
            logStream = tcpClient.GetStream();

            new Thread(Loger).Start();
        }

        private void Loger() 
        {
            while (true)
            {
                byte[] buffer = new byte[8192];
                logStream.Read(buffer, 0, buffer.Length);
                LogViwer.Invoke(new Action(() => { LogViwer.Text += "\r\n" + Encoding.UTF8.GetString(buffer); }));
            }
        }

        private void UpdaterCount()
        {
            CountClient.Invoke(new Action(() => { CountClient.Text = "Clients/Клиентов: " + server.countClients(); }));
        }

        private void ServerrChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
            Environment.Exit(0);
        }
    }
}
