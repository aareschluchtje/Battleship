using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class OpponentForm : Form
    {
        private List<Tuple<int, int, bool>> shotsFired;
        private Tuple<int, int> currentTarget;
        private Image cross, target, hit;
        private Graphics g;
        private ClientClass client;
        private Server server;
        private int victoryCount;
        private GameForm form;

        public OpponentForm(ClientClass client, GameForm form)
        {
            this.form = form;
            this.client = client;
            StartGame();
        }

        public OpponentForm(Server server, GameForm form)
        {
            this.form = form;
            this.server = server;
            StartGame();
        }

        private void StartGame()
        {
            this.InitializeComponent();
            form.wait = false;
            shotsFired = new List<Tuple<int, int, bool>>();
            cross = new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\cross.png");
            target = new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\target.png");
            hit = new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\hit.png");
            g = pictureBox1.CreateGraphics();
            timer1.Start();
            currentTarget = new Tuple<int, int>(0, 0);
            labelVictory.Hide();
            labelDefeat.Hide();
            this.victoryCount = 0;
            labelWaitingForEnemy.Hide();
        }

        public void repaint()
        {
            this.Refresh();
            for (int i = 0; i < shotsFired.Count; i++)
            {
                if (shotsFired[i].Item3)
                {
                    g.DrawImage(hit, new Point(shotsFired[i].Item1*50, shotsFired[i].Item2*50));
                }
                else
                {
                    g.DrawImage(cross, new Point(shotsFired[i].Item1*50, shotsFired[i].Item2*50));
                }
            }
            g.DrawImage(target, new Point(currentTarget.Item1, currentTarget.Item2));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!form.wait)
            {
                bool equal = false;
                foreach (Tuple<int,int,bool> shot in shotsFired)
                {
                    Tuple<int, int> coordinate =
                        new Tuple<int, int>(
                            this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X%50,
                            this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67)%50 - 70);
                    coordinate = new Tuple<int, int>(coordinate.Item1/50, coordinate.Item2/50+1);
                    if (coordinate.Item1 == shot.Item1 && coordinate.Item2 == shot.Item2)
                        equal = true;
                }
                if (!equal)
                {
                    currentTarget = new Tuple<int, int>(this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X % 50, this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70);
                    Console.WriteLine(currentTarget);
                    Fire.Enabled = true;
                }
            }
            repaint();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (server != null)
            {
                if (form.wait)
                {
                    if (server.hit == 2)
                    {
                        shotsFired.Add(new Tuple<int, int, bool>(currentTarget.Item1/50, (currentTarget.Item2/50)+1, true));
                        currentTarget = new Tuple<int, int>(0, 0);
                        server.hit = 0;
                        repaint();
                    }
                    else if (server.hit == 1)
                    {
                        shotsFired.Add(new Tuple<int, int, bool>(currentTarget.Item1/50, (currentTarget.Item2/50)+1, false));
                        currentTarget = new Tuple<int, int>(0, 0);
                        server.hit = 0;
                        repaint();
                    }
                }
                if(server.victory)
                {
                    labelVictory.Show();
                    victoryCount++;
                }
            }
            if (client != null)
            {
                if (form.wait)
                {
                    if (client.hit == 2)
                    {
                        shotsFired.Add(new Tuple<int, int, bool>((currentTarget.Item1/50), currentTarget.Item2/50+1, true));
                        currentTarget = new Tuple<int, int>(0,0);
                        client.hit = 0;
                        repaint();
                    }
                    else if (client.hit == 1)
                    {
                        shotsFired.Add(new Tuple<int, int, bool>((currentTarget.Item1/50), currentTarget.Item2/50+1, false));
                        currentTarget = new Tuple<int, int>(0,0);
                        client.hit = 0;
                        repaint();
                    }
                }
                if (client.victory)
                {
                    labelVictory.Show();
                    victoryCount++;
                }
                if (form.defeat)
                {
                    labelDefeat.Show();
                    victoryCount++;
                }
            }
           
            if (victoryCount > 150)
            {
                MenuForm menuform = new MenuForm();
                menuform.Show();
                form.defeat = false;
                form.Close();
                if (client != null)
                {
                    client.victory = false;
                    client.closeConnection();
                }
                else
                {
                    server.victory = false;
                    server.closeConnection();
                }
                
                victoryCount = 0;
                this.Close();
            }
            if (!form.wait)
            {
                labelWaitingForEnemy.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fire.Enabled = false;
            form.wait = true;
            labelWaitingForEnemy.Show();
            if (server != null)
            {
                server.sendMessage("i+" + (currentTarget.Item1/50) + "," + (currentTarget.Item2/50+1));
            }
            if (client != null)
            {
                client.sendMessage("i+" + (currentTarget.Item1/50) + "," + (currentTarget.Item2/50+1));
            }
        }
    }
}
