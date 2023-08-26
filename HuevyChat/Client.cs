using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HueChat
{
    public class Client
    {
        TcpClient tcpClient;
        NetworkStream stream;
        Thread reader;
        Thread isConnectedThread;
        string[] hostName;
        private string Nick;
        private string msg;

        public Client(string Nick, string IP)
        {
            this.Nick = Nick;
            hostName = IP.Split(':'); 

            tcpClient = new TcpClient(hostName[0], int.Parse(hostName[1]));
            stream = tcpClient.GetStream();

            reader = new Thread(Read);
            reader.Start();

            isConnectedThread = new Thread(isConnected);
            isConnectedThread.Start();
        }

        private void isConnected()
        {
            while (true)
            {
                if (!tcpClient.Connected)
                {
                    msg = "Server closed. Please restart application";
                }
            }
        }

        private void Read()
        {
           while (true)
           {
                try
                {
                    byte[] buffer = new byte[2048];
                    stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.UTF8.GetString(buffer);
                }
                catch { }
            }
        }

        public void Writer(string msg)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(Nick + ": " + msg);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            } catch { }
        }

        public string getMSG()
        {
            return msg;
        }

        public void Close()
        {
            stream.Close();
            tcpClient.Close();
        }
    }
}
