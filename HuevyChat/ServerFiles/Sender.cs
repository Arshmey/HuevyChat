using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HueChat.ServerFiles
{
    internal class Sender
    {
        Server server;
        Dictionary<string, NetworkStream> stream;
        Thread senderMSG;
        private string ID;
        private string NICK;
        private string msg;

        public Sender(Server server, Dictionary<string, NetworkStream> stream, string ID)
        {
            this.server = server;
            this.stream = stream;
            this.ID = ID;

            senderMSG = new Thread(SenderMSG);
            senderMSG.Start();
        }

        private void SenderMSG()
        {
            while (true)
            {
                bool isCommand = false;
                try
                {
                    byte[] bufRead = new byte[1048576];
                    stream[ID].Read(bufRead, 0, bufRead.Length);
                    bufRead = bufRead.Where(x => x > 0).ToArray();
                    msg = Encoding.UTF8.GetString(bufRead);
                    if (msg.Contains("/NICK: ")) { msg = msg.Replace("/NICK: ", ""); NICK = msg; isCommand = true; Welcome(NICK); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Readder: " + ex.Message);
                    StopAll();
                    break;
                }

                try
                {
                    if (!isCommand)
                    {
                        foreach (NetworkStream send in stream.Values)
                        {
                            if (send.CanWrite)
                            {
                                byte[] bufSend = Encoding.UTF8.GetBytes(msg);
                                send.Write(bufSend, 0, bufSend.Length);
                                send.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sender: " + ex.Message);
                }
            }
        }

        private void Welcome(string NICK)
        {
            byte[] helloBuf = Encoding.UTF8.GetBytes("Welcome to Cumzone " + NICK + ".");
            stream[ID].Write(helloBuf, 0, helloBuf.Length);
            stream[ID].Flush();

            foreach (NetworkStream newUserStream in stream.Values)
            {
                if (newUserStream.CanWrite && (newUserStream != stream[ID]))
                {
                    byte[] bufSend = Encoding.UTF8.GetBytes("\r\n" + NICK + " now joined");
                    newUserStream.Write(bufSend, 0, bufSend.Length);
                    newUserStream.Flush();
                }
            }
        }

        private void StopAll()
        {
            stream[ID].Close();
            server.deleteVoidClient(ID, NICK);
            senderMSG.Abort();
        }

        public string MSGlog()
        {
            return msg;
        }

    }
}
