using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace HueChat.ServerFiles
{
    public class Server
    {
        TcpListener serverClient;
        Dictionary<string, TcpClient> client = new Dictionary<string, TcpClient>();
        Dictionary<string, NetworkStream> stream = new Dictionary<string, NetworkStream>();
        Dictionary<string, Sender> senderThread = new Dictionary<string, Sender>();
        private string ID;
        private char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

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
                GenerateID();
                client.Add(ID, serverClient.AcceptTcpClient());
                stream.Add(ID, client[ID].GetStream());
                senderThread.Add(ID, new Sender(this, stream, ID));
            }
        }

        private void GenerateID()
        {
            for (int i = 0; i != 12; i++ )
            {
                if (i == 2 || i == 5 || i == 8)
                {
                    ID += "-";
                }else { ID += alphabet[new Random().Next(0, alphabet.Length - 1)]; }
            }
        }

        public void deleteVoidClient(string ID, string NICK)
        {
            client[ID].Close();
            client.Remove(ID);
            stream.Remove(ID);
            senderThread.Remove(ID);
            Console.WriteLine("Void client deleted.");
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
