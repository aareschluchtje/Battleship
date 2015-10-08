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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void draw()
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            for(int i = 0; i < 10; i++)
            {
                g.DrawLine(new Pen(Color.Black, 10), new Point(i*100, 0), new Point(i*100, 800));
            }
        }
        
    }
}
