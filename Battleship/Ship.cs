using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
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
    }
}
