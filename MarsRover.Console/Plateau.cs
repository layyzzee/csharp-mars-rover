using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class Plateau
    {
        private PlateauSize _size;
        public Plateau CurrentPlateau;
        public int Length => _size.length;
        public int height => _size.height;
        public Plateau(PlateauSize size)
        {
            if (size == null) throw new ArgumentNullException();
            if((size.length < 0 || size.height < 0) || (size.length > 10 || size.height > 10))
            {
                throw new ArgumentOutOfRangeException();
            }
            _size = size;
        }
        public bool IsWithinPlateauSize(int xCoord, int yCoord)
        {
            return xCoord >= 0 && xCoord <= _size.length && yCoord >= 0 && yCoord <= _size.height;
        }
    }
}
