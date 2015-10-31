﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleship
{
    public class ClientClass
    {
        public ClientThread cl;
        public string naam;

        public ClientClass()
        {
            TcpClient tcpclient = new TcpClient("127.0.0.1", 1000);
            cl = new ClientThread(tcpclient, this);

            Thread thread = new Thread(cl.run);
            thread.Start();
        }

        public ClientClass(TcpClient tcpClient)
        {
            cl = new ClientThread(tcpClient, this);

            Thread thread = new Thread(cl.run);
            thread.Start();
        }

        public void sendMessage(string message)
        {
            cl.sendMessage(message);
        }
    }
}
