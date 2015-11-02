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
        private string ip = null;
        private string port = null;
        Form oldForm;

        public NewGame(bool isHost, string name, Form oldForm)
        {
            this.oldForm = oldForm;
            Player1 = name; 
            server = new Server();
            this.ip = null;
            this.port = null;
            this.isHost = isHost;
            InitializeComponent();
            this.button_Start.Hide();
            label_PlayerOne.Text += Player1;
            label_IP.Text += "127.0.0.1";
            label_Port.Text += "1000";
            //Packet_NameMessage temp1 = (Packet_NameMessage)client.received;
            //label_Player2.Text += temp1.message;
        }

        public NewGame(bool isHost, string name, ClientClass client,Form oldForm, string ip, string port)
        {
            Player2 = name;

            this.Name = "Load game";
            this.oldForm = oldForm;
            this.isHost = isHost;
            this.client = client;
            this.ip = ip;
            this.port = port;

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
            Form temp = null;
            if (isHost)
            {
                temp = new GameForm(server, label_PlayerOne.Text);
            }
            else
            {
                temp = new GameForm(client, label_Player2.Text);
            }
            temp.Show();
            this.Hide();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }

        private void label_PlayerOne_Click(object sender, EventArgs e)
        {

        }

        private void button_LoadGame_Click(object sender, EventArgs e)
        {
            if (isHost && label_Player2.Text.Length < 10)
            {
                server.sendMessage("p+" + Player1);
                label_Player2.Text += server.name;
                if (server.name != null)
                {
                    this.button_Start.Show();
                }
            }
            else if(label_PlayerOne.Text.Length < 10 && !isHost)
            {
                client.sendMessage("p+" + Player2);
                label_PlayerOne.Text += client.name;
                label_IP.Text += ip;
                label_Port.Text += port;
                if (client.name != null)
                {
                    this.button_Start.Show();
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            oldForm.Show();
            this.Hide();
        }
    }
}
