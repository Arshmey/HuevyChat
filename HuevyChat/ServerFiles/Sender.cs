using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HueChat.ServerFiles
{
    internal class Sender
    {
        Server server;
        List<NetworkStream> stream;
        Thread senderMSG;
        private int youPosition;
        private bool work = true;
        private string msg;

        public Sender(Server server, List<NetworkStream> stream, int youPosition)
        {
            this.server = server;
            this.stream = stream;
            this.youPosition = youPosition;

            senderMSG = new Thread(SenderMSG);
            senderMSG.Start();
        }

        private void SenderMSG()
        {
            while (work)
            {
                try
                {
                    byte[] bufRead = new byte[2048];
                    stream[youPosition].Read(bufRead, 0, bufRead.Length);
                    msg = Encoding.UTF8.GetString(bufRead);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Readder: " + ex.Message);
                    StopAll();
                }

                try
                {
                    foreach (NetworkStream send in stream)
                    {
                        if (send.CanWrite)
                        {
                            byte[] bufSend = Encoding.UTF8.GetBytes(msg);
                            send.Write(bufSend, 0, bufSend.Length);
                            send.Flush();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sender: " + ex.Message);
                }
            }
        }

        public void StopAll()
        {
            work = false;
            stream[youPosition].Close();
            server.deleteVoidClient(youPosition);
            senderMSG.Abort();
        }

        public void ResetPosition(int pos)
        {
            youPosition = pos;
        }

        public string MSGlog()
        {
            return msg;
        }

    }
}
