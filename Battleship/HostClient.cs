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
    class HostClient
    {
        public NetworkStream stream { get; set; }
        public TcpClient tcpClient { get; set; }
        

        private string username;

        public HostClient(TcpClient tcpClient)
        {
            
            this.tcpClient = tcpClient;
            stream = tcpClient.GetStream();
            new Thread(() =>
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while (tcpClient.Connected)
                {
                    Packet packet = (Packet)formatter.Deserialize(stream);
                    packet.handleServerSide();
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
