using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public record class Plateau
    {
        private readonly PlateauSize _size;
        public Plateau(PlateauSize size)
        {
            _size = size;
            if(size.Lengh < 0 || size.Height < 0) throw new ArgumentOutOfRangeException("Input must be Positive input");
            if (size.Lengh > 10 || size.Height > 10) throw new ArgumentOutOfRangeException("Input must be less than 10");
        }
        public bool IsWithinPlateau(int xCoord, int yCoord)
        {
            return xCoord >= 0 && xCoord <= _size.Lengh && yCoord >= 0 && yCoord <= _size.Height;
        }
    }
}
