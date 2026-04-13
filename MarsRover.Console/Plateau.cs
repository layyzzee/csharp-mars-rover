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
            Length = length;
            Height = height;
        }
    }
}
