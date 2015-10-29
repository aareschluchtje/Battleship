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
        bool isHost;
        string Player1;
        string Player2;
        public NewGame(bool isHost,string naam)
        {
            if (!isHost)
            {
                this.button_Start.Hide();
                Player2 = naam;
            }
            else
            {
                Player1 = naam;
            }

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
    }
}
