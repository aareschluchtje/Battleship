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
            
            if (!isHost)
            {
                this.button_Start.Hide();
                Player2 = naam;
                //this.label_Player2.Text += Player2;
            }
            else
            {
                Player1 = naam;
                //this.label_PlayerOne.Text += Player1;
                Server server = new Server();
                System.Net.Sockets.TcpClient temp = new System.Net.Sockets.TcpClient();
                temp.Connect("127.0.0.1", 1000);
                client = new ConnectClient(temp, server);
            }
            this.isHost = isHost;
            InitializeComponent();
        }

        public NewGame(bool isHost, string naam, ConnectClient client)
        {
            if (!isHost)
            {
                this.button_Start.Hide();
                Player2 = naam;
                this.label_Player2.Text += Player2;
            }
           
            this.isHost = isHost;
            this.client = client;


            InitializeComponent();

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
    }
}
