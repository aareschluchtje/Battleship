using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class FindGame : Form
    {
        private TcpClient client;
        string naam;
        Form oldForm;
        BinaryFormatter formatter;
        public FindGame(string naam,Form oldForm)
        {
            this.oldForm = oldForm;
            this.naam = naam;
            formatter = new BinaryFormatter();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FindGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            client = new TcpClient(textBoxIP.Text,int.Parse(textBoxPort.Text));
            ClientClass tcpclient = new ClientClass(client);
            Form z = new NewGame(false,naam,tcpclient,this, textBoxIP.Text, textBoxPort.Text);
            z.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldForm.Show();
        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
