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
            for(int i = 0; i < 12; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), new Point(i*40, 0), new Point(i*40, 800));
            }
            for (int i = 0; i < 12; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), new Point(0, i*38), new Point(800, i*38));
                if (i > 0 && i < 12)
                {
                    g.DrawString(i + "", new Font(new FontFamily("Arial"), 20 ), new SolidBrush(Color.Black), new PointF(0, i * 38 + 10));
                }
            }
        }
        
    }
}
