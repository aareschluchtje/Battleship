using System;
using System.Collections;
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
    public partial class GameForm : Form
    {
        private List<Ship> ships; 
        private bool setup = true;

        public GameForm()
        {
            InitializeComponent();
            ReadyButton.Enabled = false;
            this.ships = new List<Ship>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PositionLabel.Text = "X = " + this.PointToClient(Cursor.Position).X + " Y = " + (this.PointToClient(Cursor.Position).Y - 67);
            Graphics g = pictureBox1.CreateGraphics();
            
            if (setup)
            {
                int x = this.PointToClient(Cursor.Position).X - this.PointToClient(Cursor.Position).X%50;
                int y = this.PointToClient(Cursor.Position).Y - (this.PointToClient(Cursor.Position).Y - 67) % 50 - 70;

                if (PatrolBoat.BackColor == Color.Green)
                {
                    g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\patrol-boat.png"), new Point(x, y));
                    PatrolBoat.BackColor = Color.Red;
                    ships.Add(new Ship(new Point(x,y), Ship.ShipType.PATROLBOAT, 0));
                }
                else if (Destroyer.BackColor == Color.Green || Submarine.BackColor == Color.Green)
                {
                    g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Destroyer.png"), new Point(x,y));
                    if (Destroyer.BackColor == Color.Green)
                    {
                        Destroyer.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x,y), Ship.ShipType.DESTROYER, 0));
                    }
                    else
                    {
                        Submarine.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x,y), Ship.ShipType.SUBMARINE, 0));
                    }
                }
                else if (Battleship.BackColor == Color.Green)
                {
                    g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Battleship.png"), new Point(x,y));
                    Battleship.BackColor = Color.Red;
                    ships.Add(new Ship(new Point(x,y), Ship.ShipType.BATTLESHIP, 0));
                }
                else if (AircraftCarrier.BackColor == Color.Green)
                {
                    g.DrawImage(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Aircraft-carrier.png"), new Point(x,y));
                    AircraftCarrier.BackColor = Color.Red;
                    ships.Add(new Ship(new Point(x,y), Ship.ShipType.AIRCRAFTCARRIER, 0));
                }
                if (PatrolBoat.BackColor == Color.Red && Destroyer.BackColor == Color.Red &&
                    Submarine.BackColor == Color.Red && Battleship.BackColor == Color.Red &&
                    AircraftCarrier.BackColor == Color.Red)
                {
                    ReadyButton.Enabled = true;
                }
            }
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
        }
    }
}
