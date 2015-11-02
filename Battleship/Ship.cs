using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Ship
    {
        public enum ShipType { PATROLBOAT, DESTROYER, SUBMARINE, BATTLESHIP, AIRCRAFTCARRIER}
        public Point Location { get; set; }
        public ShipType Type { get; }
        public int Rotation { get; set; }

        public Ship(Point location, ShipType type, int rotation)
        {
            Location = location;
            Type = type;
            Rotation = rotation;
        }

        public List<Tuple<int,int>> getCoordinates()
        {
            List<Tuple<int,int>> coordinates = new List<Tuple<int,int>>();
            int x = Location.X / 50;
            int y = Location.Y / 50;
            coordinates.Add(new Tuple<int, int>(x,y));
            switch (Type)
            {
                case ShipType.PATROLBOAT:
                    if (Rotation == 0)
                    {
                        coordinates.Add(new Tuple<int, int>(x + 1,y));
                    }
                    else if (Rotation == 90)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y + 1));
                    }
                    else if (Rotation == 180)
                    {
                        coordinates.Add(new Tuple<int, int>(x - 1, y));
                    }
                    else if (Rotation == 270)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y - 1));
                    }
                    break;
                 case ShipType.DESTROYER:
                    if (Rotation == 0)
                    {
                        coordinates.Add(new Tuple<int, int>(x + 1, y));
                        coordinates.Add(new Tuple<int, int>(x + 2, y));
                    }
                    else if (Rotation == 90)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y + 1));
                        coordinates.Add(new Tuple<int, int>(x, y + 2));
                    }
                    else if (Rotation == 180)
                    {
                        coordinates.Add(new Tuple<int, int>(x - 1, y));
                        coordinates.Add(new Tuple<int, int>(x - 2, y));
                    }
                    else if (Rotation == 270)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y - 1));
                        coordinates.Add(new Tuple<int, int>(x, y - 2));
                    }
                    break;
                case ShipType.SUBMARINE:
                    if (Rotation == 0)
                    {
                        coordinates.Add(new Tuple<int, int>(x + 1, y));
                        coordinates.Add(new Tuple<int, int>(x + 2, y));
                    }
                    else if (Rotation == 90)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y + 1));
                        coordinates.Add(new Tuple<int, int>(x, y + 2));
                    }
                    else if (Rotation == 180)
                    {
                        coordinates.Add(new Tuple<int, int>(x - 1, y));
                        coordinates.Add(new Tuple<int, int>(x - 2, y));
                    }
                    else if (Rotation == 270)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y - 1));
                        coordinates.Add(new Tuple<int, int>(x, y - 2));
                    }
                    break;
                case ShipType.BATTLESHIP:
                    if (Rotation == 0)
                    {
                        coordinates.Add(new Tuple<int, int>(x + 1, y));
                        coordinates.Add(new Tuple<int, int>(x + 2, y));
                        coordinates.Add(new Tuple<int, int>(x + 3, y));
                    }
                    else if (Rotation == 90)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y + 1));
                        coordinates.Add(new Tuple<int, int>(x, y + 2));
                        coordinates.Add(new Tuple<int, int>(x, y + 3));
                    }
                    else if (Rotation == 180)
                    {
                        coordinates.Add(new Tuple<int, int>(x - 1, y));
                        coordinates.Add(new Tuple<int, int>(x - 2, y));
                        coordinates.Add(new Tuple<int, int>(x - 3, y));
                    }
                    else if (Rotation == 270)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y - 1));
                        coordinates.Add(new Tuple<int, int>(x, y - 2));
                        coordinates.Add(new Tuple<int, int>(x, y - 3));
                    }
                    break;
                case ShipType.AIRCRAFTCARRIER:
                    if (Rotation == 0)
                    {
                        coordinates.Add(new Tuple<int, int>(x + 1, y));
                        coordinates.Add(new Tuple<int, int>(x + 2, y));
                        coordinates.Add(new Tuple<int, int>(x + 3, y));
                        coordinates.Add(new Tuple<int, int>(x + 4, y));
                    }
                    else if (Rotation == 90)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y + 1));
                        coordinates.Add(new Tuple<int, int>(x, y + 2));
                        coordinates.Add(new Tuple<int, int>(x, y + 3));
                        coordinates.Add(new Tuple<int, int>(x, y + 4));
                    }
                    else if (Rotation == 180)
                    {
                        coordinates.Add(new Tuple<int, int>(x - 1, y));
                        coordinates.Add(new Tuple<int, int>(x - 2, y));
                        coordinates.Add(new Tuple<int, int>(x - 3, y));
                        coordinates.Add(new Tuple<int, int>(x - 4, y));
                    }
                    else if (Rotation == 270)
                    {
                        coordinates.Add(new Tuple<int, int>(x, y - 1));
                        coordinates.Add(new Tuple<int, int>(x, y - 2));
                        coordinates.Add(new Tuple<int, int>(x, y - 3));
                        coordinates.Add(new Tuple<int, int>(x, y - 4));
                    }
                    break;
            }
            return coordinates;
        }
    }
}
