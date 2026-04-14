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
            Compass nextDirection = CurrentPosition.Direction;
            if (movement == Instruction.R)
            {
                nextDirection = CurrentPosition.Direction switch
                {
                    Compass.N => Compass.E,
                    Compass.E => Compass.S,
                    Compass.S => Compass.W,
                    Compass.W => Compass.N,
                    _ => CurrentPosition.Direction
                };
            }
            else if (movement == Instruction.L)
            {
                nextDirection = CurrentPosition.Direction switch
                {
                    Compass.N => Compass.W,
                    Compass.W => Compass.S,
                    Compass.S => Compass.E,
                    Compass.E => Compass.N,
                    _ => CurrentPosition.Direction
                };
            }
            CurrentPosition = CurrentPosition with { Direction = nextDirection };
        }

        public void MoveForward(Instruction Movement)
        {
            if (Movement == Instruction.M)
            {
                switch (CurrentPosition.Direction)
                {
                    case Compass.N: CurrentPosition = CurrentPosition with { YCoord = CurrentPosition.YCoord + 1 }; break;
                    case Compass.E: CurrentPosition = CurrentPosition with { XCoord = CurrentPosition.XCoord + 1 }; break;
                    case Compass.S: CurrentPosition = CurrentPosition with { YCoord = CurrentPosition.YCoord - 1 }; break;
                    case Compass.W: CurrentPosition = CurrentPosition with { XCoord = CurrentPosition.XCoord - 1 }; break;
                }
            }
        }

        public Position Drive(List<Instruction> input)
        {
            foreach (var instruction in input)
            {
                if (instruction == Instruction.M)
                {
                    MoveForward(instruction);
                }
                else
                {
                    Rotate(instruction);
                }
            }
            return CurrentPosition;
        }
    }
}
