using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class ServerClientThread
    {
        private TcpClient tcpClient;
        private Server server;
        private StreamReader reader;
        private StreamWriter writer;

        public ServerClientThread(TcpClient tcpClient, Server server)
        {
            this.tcpClient = tcpClient;
            this.server = server;
            this.reader = new StreamReader(tcpClient.GetStream(), Encoding.ASCII);
            this.writer = new StreamWriter(tcpClient.GetStream(), Encoding.ASCII);
        }

        public void run()
        {
            while (true)
            {
                string message = reader.ReadLine();
                Console.WriteLine(message);
                if (message != null)
                {
                    if (message.StartsWith("p"))
                    {
                        server.name = message.Remove(0, 2);
                    }
                    else if (message.StartsWith("h"))
                    {
                        server.hit = int.Parse(message.Remove(0, 2));
                    }
                    else if (message.StartsWith("i"))
                    {
                        message = message.Remove(0, 2);
                        string[] coordinates = message.Split(',');
                        server.impact = new Tuple<int, int>(int.Parse(coordinates[0]), int.Parse(coordinates[1]));
                    }
                    else if (message.StartsWith("v"))
                    {
                        server.victory = Boolean.Parse(message.Remove(0, 2));
                    }
                    else if (message.StartsWith("r"))
                    {
                        server.ready = Boolean.Parse(message.Remove(0, 2));
                    }
                    Console.WriteLine(message);
                }
            }
        }

        public void writeMessage(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }
    }
}
