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
        private NetworkStream stream;
        string naam;
        BinaryFormatter formatter;
        public FindGame(string naam)
        {
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
            stream = client.GetStream();
            ReceiveThread();
        }
        private void ReceiveThread()
        {
            while (true)
            {
                Packet packet = (Packet)formatter.Deserialize(stream);
                if (packet != null)
                    packet.handleClientSide();
            }
        }
    }
}
