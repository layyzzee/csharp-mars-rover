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
            Compass currentDirection = CurrentPosition.Direction;
            Compass nextDirection = currentDirection;
            if (movement == Movement.R)
            {
                nextDirection = currentDirection switch
                {
                    Compass.N => Compass.E,
                    Compass.E => Compass.S,
                    Compass.S => Compass.W,
                    Compass.W => Compass.N,
                    _ => currentDirection
                };
            }
            else if (movement == Movement.L)
            {
                nextDirection = currentDirection switch
                {
                    Compass.N => Compass.W,
                    Compass.W => Compass.S,
                    Compass.S => Compass.E,
                    Compass.E => Compass.N,
                    _ => currentDirection
                };
            }
            CurrentPosition = CurrentPosition with { Direction = nextDirection };
        }
    }
}
