using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string name;
        public int hit = 0; 
        public Tuple<int, int> impact;
        public bool victory = false;
        public bool ready = false;

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

        public void closeConnection()
        {
            cl.closeConnection();
        }
    }
}
