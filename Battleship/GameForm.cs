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
        private int rotation = 0;
        private ClientClass client;
        private Server server;

        public GameForm(ClientClass client)
        {
            StartGame();
            this.client = client;
        }

        public GameForm(Server server)
        {
            StartGame();
            this.server = server;
        }

        public void StartGame()
        {
            InitializeComponent();
            ReadyButton.Enabled = false;
            this.ships = new List<Ship>();
            this.hits = new List<Tuple<int, int>>();
            this.g = pictureBox1.CreateGraphics();
            this.images = new List<Image>();
            this.waitingLabel.Hide();
        }

        public void repaint()
        {
            this.Refresh();
            for(int i = 0; i < images.Count; i++)
            {
                g.TranslateTransform(ships[i].Location.X, ships[i].Location.Y);
                g.RotateTransform(ships[i].Rotation);
                g.DrawImage(images[i], new Point(0,0));
                g.ResetTransform();
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
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.PATROLBOAT, rotation));
                    }
                    else if (Destroyer.BackColor == Color.Green || Submarine.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Destroyer.png"));
                        if (Destroyer.BackColor == Color.Green)
                        {
                            Destroyer.BackColor = Color.Red;
                            ships.Add(new Ship(new Point(x, y), Ship.ShipType.DESTROYER, rotation));
                        }
                        else
                        {
                            Submarine.BackColor = Color.Red;
                            ships.Add(new Ship(new Point(x, y), Ship.ShipType.SUBMARINE, rotation));
                        }
                    }
                    else if (Battleship.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Battleship.png"));
                        Battleship.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.BATTLESHIP, rotation));
                    }
                    else if (AircraftCarrier.BackColor == Color.Green)
                    {
                        images.Add(new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\images\\Aircraft-carrier.png"));
                        AircraftCarrier.BackColor = Color.Red;
                        ships.Add(new Ship(new Point(x, y), Ship.ShipType.AIRCRAFTCARRIER, rotation));
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
            if (client != null)
            {
                client.sendMessage("r+true");
                if (client.ready)
                {
                    Form opponentForm = new OpponentForm(client);
                    opponentForm.Show();
                    setup = false;
                    ReadyButton.Hide();
                    button_Reset.Hide();
                }
                else
                {
                    waitingLabel.Show();
                }
            }
            else if (server != null)
            {
                if (server.ready)
                {
                    server.sendMessage("r+true");
                    Form opponentForm = new OpponentForm(server);
                    opponentForm.Show();
                    setup = false;
                    ReadyButton.Hide();
                    button_Reset.Hide();
                }
                else
                {
                    waitingLabel.Show();
                }
            }
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

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            if(rotation == 0)
            {
                rotation = 90;
                button_Rotate.ResetText();
                button_Rotate.Text += " " + rotation;
            }
            else
            {
                rotation = 0;
                button_Rotate.ResetText();
                button_Rotate.Text += " " + rotation;
            }
        }
    }
}
