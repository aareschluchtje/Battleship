using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class NewGame : Form
    {
        public bool isHost;
        public string Player1 = "";
        public string Player2= "";
        public ConnectClient client;
        public NewGame(bool isHost,string naam)
        {
            
            
           Player1 = naam; 
           Server server = new Server();
           System.Net.Sockets.TcpClient temp = new System.Net.Sockets.TcpClient("127.0.0.1",1000);
           temp.Connect("127.0.0.1", 1000);
           client = new ConnectClient(temp, server);
            
            this.isHost = isHost;
            InitializeComponent();
            label_PlayerOne.Text += Player1;
            label_IP.Text += server.ip;
            label_Port.Text += server.port;
            //Packet_NameMessage temp1 = (Packet_NameMessage)client.received;
            //label_Player2.Text += temp1.message;
        }

        public NewGame(bool isHost, string naam, ConnectClient client)
        {
          
            
            Player2 = naam;
                
       
           
            this.isHost = isHost;
            this.client = client;


            InitializeComponent();
            this.button_Start.Hide();
            this.label_Player2.Text += Player2;
            label_PlayerOne.Text += Player1;
           
            //Packet_NameMessage temp1 = (Packet_NameMessage)client.received;
            //label_PlayerOne.Text += temp1.message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }

        private void label_PlayerOne_Click(object sender, EventArgs e)
        {

        }

        private void button_LoadGame_Click(object sender, EventArgs e)
        {
            if (isHost)
                client.sendPacket(new Packet_NameMessage(Player1, true));
            else
                client.sendPacket(new Packet_NameMessage(Player2, true));
            if (client.received != null)
            {
                
                Packet_NameMessage temp1 = (Packet_NameMessage)client.received;
                label_Player2.Text += temp1.message;
            }
        }
    }
}
