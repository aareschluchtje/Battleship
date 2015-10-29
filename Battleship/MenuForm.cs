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


        private void button_FindGame_Click(object sender, EventArgs e)
        {
            Form y = new FindGame(textBox_Name.Text);
            y.Show();
            this.Hide();
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            Form z = new NewGame(true,textBox_Name.Text);
            z.Show();
            this.Hide();
        }
    }
}
