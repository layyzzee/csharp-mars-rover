using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console
{
    public record class Position
    {
        public int XCoord {  get; set; }
        public int YCoord { get; set; }
        public Compass Direction { get; set; }
        public Position(int xCoord, int yCoord, Compass direction)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            Direction = direction;
        }
    }
}
