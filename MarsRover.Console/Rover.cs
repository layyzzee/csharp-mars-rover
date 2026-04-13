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

        public void Rotate(Instruction movement)
        {
            Compass currentDirection = CurrentPosition.Direction;
            Compass nextDirection = currentDirection;
            if (movement == Instruction.R)
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
            else if (movement == Instruction.L)
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

        public void Move()
        {
            var currentDirection = CurrentPosition.Direction;
            switch (currentDirection)
            {
                case Compass.N: CurrentPosition = CurrentPosition with { YCoord = CurrentPosition.YCoord + 1 }; break;
                case Compass.E: CurrentPosition = CurrentPosition with { XCoord = CurrentPosition.XCoord + 1 }; break;
                case Compass.S: CurrentPosition = CurrentPosition with { YCoord = CurrentPosition.YCoord - 1 }; break;
                case Compass.W: CurrentPosition = CurrentPosition with { XCoord = CurrentPosition.XCoord - 1 }; break;
            }
        }
    }
}
