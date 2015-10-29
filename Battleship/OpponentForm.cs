using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class OpponentForm : Form
    {
        private bool setup = true;
        public OpponentForm()
        {
            this.InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\cross.png"), new Point(this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X % 50, this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if(PatrolBoat.BackColor != Color.Red)
            //PatrolBoat.BackColor = Color.Green;
        }

        private void Battleship_Click(object sender, EventArgs e)
        {
            //if(Battleship.BackColor != Color.Red)
            //Battleship.BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Destroyer_Click(object sender, EventArgs e)
        {
            //if(Destroyer.BackColor != Color.Red)
            //Destroyer.BackColor = Color.Green;
        }

        private void Submarine_Click(object sender, EventArgs e)
        {
            //if(Submarine.BackColor != Color.Red)
            //Submarine.BackColor = Color.Green;
        }

        private void AircraftCarrier_Click(object sender, EventArgs e)
        {
            //if(AircraftCarrier.BackColor != Color.Red)
            //AircraftCarrier.BackColor = Color.Green;
        }
    }
}
