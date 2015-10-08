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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_LoadGame_Click(object sender, EventArgs e)
        {
            Form x = new GameForm();
            x.Show();
            this.Hide();
        }
    }
}
