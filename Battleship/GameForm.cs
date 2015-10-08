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
        private bool setup = true;
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
            string[] digits = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"};
            for(int i = 0; i < 12; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), new Point(i*40, 0), new Point(i*40, 420));
                if (i > 0 && i < 11)
                {
                    g.DrawString(digits[i-1], new Font(new FontFamily("Arial"), 20), new SolidBrush(Color.Black), new PointF(i * 40 + 10, 5));
                }
            }
            for (int i = 0; i < 12; i++)
            {
                g.DrawLine(new Pen(Color.Black, 5), new Point(0, i*38), new Point(440, i*38));
                if (i > 0 && i < 11)
                {
                    g.DrawString(i + "", new Font(new FontFamily("Arial"), 20 ), new SolidBrush(Color.Black), new PointF(5, i * 38 + 10));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
