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
        public Server server;
        public ClientClass client;
        Form oldForm;

        public NewGame(bool isHost, string naam, Form oldForm)
        {
            this.oldForm = oldForm;
            Player1 = naam; 
            server = new Server();

            this.isHost = isHost;
            InitializeComponent();
            label_PlayerOne.Text += Player1;
            label_IP.Text += "127.0.0.1";
            label_Port.Text += "1000";
            //Packet_NameMessage temp1 = (Packet_NameMessage)client.received;
            //label_Player2.Text += temp1.message;
        }

        public NewGame(bool isHost, string naam, ClientClass client,Form oldForm)
        {
            Player2 = naam;

            this.oldForm = oldForm;
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
            Form temp = new GameForm(client);
            this.Hide();
            temp.Show();
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
            {
                server.sendMessage(Player1);
                label_Player2.Text += server.naam;
            }
            else
            {
                client.sendMessage(Player2);
                label_PlayerOne.Text += client.naam;
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            oldForm.Show();
            this.Hide();
        }
    }
}
