using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace HueChat.ServerFiles
{
    public class Server
    {
        TcpListener serverClient;
        List<TcpClient> client = new List<TcpClient>();
        List<NetworkStream> stream = new List<NetworkStream>();
        List<Sender> senderThread = new List<Sender>();

        public Server(int PORT)
        {
            serverClient = new TcpListener(IPAddress.Any, PORT);
            serverClient.Start();

            Thread accept = new Thread(acceptClients);
            accept.Start();
        }

        private void acceptClients()
        {
            while (true)
            {
                client.Add(serverClient.AcceptTcpClient());
                stream.Add(client[(client.Count - 1)].GetStream());
                senderThread.Add(new Sender(this, stream, (client.Count - 1)));
                Console.WriteLine("Done");

                if (client.Count - 1 != 0)
                {
                    byte[] helloBuf = Encoding.UTF8.GetBytes("Welcoe to Cumzone.");
                    stream[(client.Count - 1)].Write(helloBuf, 0, helloBuf.Length);
                    stream[(client.Count - 1)].Flush();
                }

            }
        }

        public void deleteVoidClient(int youPosition)
        {
            client[youPosition].Close();
            client.RemoveAt(youPosition);
            stream.RemoveAt(youPosition);
            senderThread.RemoveAt(youPosition);
            Console.WriteLine("Void client deleted.");

            for (int Position = 1; Position != senderThread.Count; Position++)
            {
                if (Position > senderThread.Count) { senderThread[Position].ResetPosition(Position); }
            }
        }

        public int countClients()
        {
            return client.Count - 1;
        }

        public void Close()
        {
            serverClient.Stop();
        }
    }
}
