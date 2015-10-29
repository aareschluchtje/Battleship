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
        private bool wait = false;
        private List<Tuple<int, int>> shotsFired;
        private Tuple<int, int> currentTarget;

        public OpponentForm()
        {
            this.InitializeComponent();
            shotsFired = new List<Tuple<int, int>>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!wait)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\cross.png"), new Point(this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X % 50, this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70));
                currentTarget = new Tuple<int, int>(this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X % 50, this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70);
                Fire.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shotsFired.Add(currentTarget);
            Fire.Enabled = false;
            wait = true;
        }
    }
}
