using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public record class Plateau
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public Plateau(int length, int height)
        {
            if(length < 0 || height < 0) throw new ArgumentOutOfRangeException("Input must be Positive input");
            if (length > 10 || height > 10) throw new ArgumentOutOfRangeException("Input must be less than 10");
            Length = length;
            Height = height;
        }
        public bool IsWithinPlateau(int xCoord, int yCoord)
        {
            return xCoord >= 0 && xCoord <= Length && yCoord >= 0 && yCoord <= Height;
        }
    }
}
