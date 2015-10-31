using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battleship
{
    public class Server
    {
        private List<ServerClientThread> clients;

        public string naam;
        public Server()
        {
            IPAddress localhost = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(localhost, 1000);
            clients = new List<ServerClientThread>();
            listener.Start();

            
            TcpClient client = listener.AcceptTcpClient();
            ServerClientThread cl = new ServerClientThread(client, this);
            clients.Add(cl);

            //Run client on new thread
            Thread thread = new Thread(new ThreadStart(cl.run));
            thread.IsBackground = true;
            thread.Start();
        }

        public void sendMessage(string message)
        {
            clients[0].writeMessage(message);
        }
    }
}
