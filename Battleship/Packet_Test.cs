using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Packet_Test:Packet
    {
        public string message { get; }
        private bool toServer;
        public Packet_Test(string Message,bool toServer)
        {
            message = Message;
            this.toServer = toServer;
        }
        public override void handleClientSide()
        {
           if(!toServer)
            {
                Console.WriteLine(message);
            }
        }
        public override void handleServerSide()
        {
            if (toServer)
            {
                Console.WriteLine(message);
            }
        }
    }   
}
