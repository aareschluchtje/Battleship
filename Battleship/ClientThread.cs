using System;
using System.Collections.Generic;
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
                client.naam = message;
                Console.WriteLine(client.naam);
            }
        }

        public void sendMessage(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }
    }
}
