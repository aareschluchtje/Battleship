using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleship
{
    public class ConnectClient
    {
        public NetworkStream stream { get; set; }
        public TcpClient tcpClient { get; set; }
        public Server program { get; }
        public Packet received;
        public bool isHost { get; }

        public ConnectClient(TcpClient tcpClient,Server program)
        {
            this.isHost = isHost;
            this.tcpClient = tcpClient;
            this.program = program;
            stream = tcpClient.GetStream();
            new Thread(() =>
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while (tcpClient.Connected)
                {
                    received = (Packet)formatter.Deserialize(stream);
                    
                }
            }).Start();
        }
        public ConnectClient(TcpClient tcpClient)
        {
            this.isHost = isHost;
            this.tcpClient = tcpClient;

            stream = tcpClient.GetStream();
            new Thread(() =>
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while (tcpClient.Connected)
                {
                    received = (Packet)formatter.Deserialize(stream);
                    if(received != null)
                    {
                        Console.WriteLine("message");
                    }

                }
            }).Start();
        }

        public void sendPacket(Packet packet)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, packet);
        }
    }

}
