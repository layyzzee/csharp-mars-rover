using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public record class PlateauSize(int length, int height)
    {
        public int Length = length;
        public int Height = height;
    }

}
