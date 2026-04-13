using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class Rover
    {
        public Position CurrentPosition;
        public Rover(Position startingPosition)
        {
            CurrentPosition = startingPosition;
        }

        public void Rotate(Movement movement)
        {

        }
    }
}
