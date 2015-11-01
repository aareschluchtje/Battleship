using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class ClientThread
    {
        private TcpClient TcpClient;
        private StreamReader reader;
        private StreamWriter writer;
        private ClientClass client;

        public ClientThread(TcpClient tcpClient, ClientClass client)
        {
            TcpClient = tcpClient;
            this.reader = new StreamReader(tcpClient.GetStream(), Encoding.ASCII);
            this.writer = new StreamWriter(tcpClient.GetStream(), Encoding.ASCII);
            this.client = client;
        }

        public void run()
        {
            while (true)
            {
                string message = reader.ReadLine();
                if (message != null)
                {
                    if (message.StartsWith("p"))
                    {
                        client.naam = message.Remove(0,2);
                    }
                    else if (message.StartsWith("h"))
                    {
                        client.hit = Boolean.Parse(message.Remove(0, 2));
                    }
                    else if (message.StartsWith("i"))
                    {
                        message = message.Remove(0, 2);
                        string[] coordinates = message.Split(',');
                        client.impact = new Tuple<int, int>(int.Parse(coordinates[0]), int.Parse(coordinates[1]));
                    }
                    else if (message.StartsWith("v"))
                    {
                        client.victory = Boolean.Parse(message.Remove(0, 2));
                    }
                    else if (message.StartsWith("r"))
                    {
                        client.ready = Boolean.Parse(message.Remove(0, 2));
                    }
                }
                Console.WriteLine(message);
            }
        }

        public void sendMessage(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }
    }
}
