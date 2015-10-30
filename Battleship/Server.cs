﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleship
{
    public class Server
    {
        private List<ConnectClient> clients = new List<ConnectClient>();

        public Server()
        {
            TcpListener listener = new TcpListener(1000);
            listener.Start();
            new Thread(() =>
            {
                while (true)
                {
                    TcpClient newClient = listener.AcceptTcpClient();
                    clients.Add(new ConnectClient(newClient, this));
                }
            }).Start();
        }
        public void broadCast(Packet packet)
        {
            foreach (ConnectClient serverClient in clients)
                serverClient.sendPacket(packet);
        }
    }
}
