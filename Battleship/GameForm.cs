using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class GameForm : Form
    {
        private List<Ship> ships; 
        private bool setup = true;
        private List<Tuple<int, int>> hits;
        private Graphics g;
        private List<Image> images; 

        public GameForm(ClientClass client)
        {
            InitializeComponent();
            ReadyButton.Enabled = false;
            this.ships = new List<Ship>();
            this.hits = new List<Tuple<int, int>>();
            this.g = pictureBox1.CreateGraphics();
            this.images = new List<Image>();
        }

        public void repaint()
        {
            this.Refresh();
            for(int i = 0; i < images.Count; i++)
            {
                g.RotateTransform(ships[i].Rotation);
                g.DrawImage(images[i], ships[i].Location);
                g.RotateTransform(-ships[i].Rotation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PositionLabel.Text = "X = " + this.PointToClient(Cursor.Position).X + " Y = " + (this.PointToClient(Cursor.Position).Y - 67);
            MouseEventArgs eventArgs = (MouseEventArgs) e;
            if (setup)
            {
                if (eventArgs.Button == MouseButtons.Left)
                {
                    int x = this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X % 50;
                    int y = this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70;

                    if (PatrolBoat.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\patrol-boat.png"));
                        PatrolBoat.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.PATROLBOAT, 0));
                    }
                    else if (Destroyer.BackColor == Color.Green || Submarine.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Destroyer.png"));
                        if (Destroyer.BackColor == Color.Green)
                        {
                            Destroyer.BackColor = Color.Red;
                            ships.Add(new Ship(new Point(x, y), Ship.ShipType.DESTROYER, 0));
                        }
                        else
                        {
                            Submarine.BackColor = Color.Red;
                            ships.Add(new Ship(new Point(x, y), Ship.ShipType.SUBMARINE, 0));
                        }
                    }
                    else if (Battleship.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Battleship.png"));
                        Battleship.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.BATTLESHIP, 0));
                    }
                    else if (AircraftCarrier.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Aircraft-carrier.png"));
                        AircraftCarrier.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.AIRCRAFTCARRIER, 0));
                    }
                    if (PatrolBoat.BackColor == Color.Red && Destroyer.BackColor == Color.Red &&
                        Submarine.BackColor == Color.Red && Battleship.BackColor == Color.Red &&
                        AircraftCarrier.BackColor == Color.Red)
                    {
                        ReadyButton.Enabled = true;
                    }
                }
                else if (eventArgs.Button == MouseButtons.Right)
                {
                    foreach(Ship ship in ships)
                    {
                        if (ship.Location.X == MousePosition.X && ship.Location.Y == MousePosition.Y)
                        {
                            
                        }
                    }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(PatrolBoat.BackColor != Color.Red)
            PatrolBoat.BackColor = Color.Green;
        }

        private void Battleship_Click(object sender, EventArgs e)
        {
            if(Battleship.BackColor != Color.Red)
            Battleship.BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Destroyer_Click(object sender, EventArgs e)
        {
            if(Destroyer.BackColor != Color.Red)
            Destroyer.BackColor = Color.Green;
        }

        private void Submarine_Click(object sender, EventArgs e)
        {
            if(Submarine.BackColor != Color.Red)
            Submarine.BackColor = Color.Green;
        }

        private void AircraftCarrier_Click(object sender, EventArgs e)
        {
            if(AircraftCarrier.BackColor != Color.Red)
            AircraftCarrier.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form opponentForm = new OpponentForm();
            opponentForm.Show();
            setup = false;
            ReadyButton.Hide();
            button_Reset.Hide();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            AircraftCarrier.BackColor = Color.Gray;
            Submarine.BackColor = Color.Gray;
            Destroyer.BackColor = Color.Gray;
            Battleship.BackColor = Color.Gray;
            PatrolBoat.BackColor = Color.Gray;
            this.ships = new List<Ship>();
            this.hits = new List<Tuple<int, int>>();
            this.g = pictureBox1.CreateGraphics();
            this.images = new List<Image>();
            repaint();
        }
    }
}
