using MarsRover.Terminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test
{
    internal class PlateauTest
    {
        [Test]
        public void PlateauParser_Return9x9_Withinputx9y9()
        {
            var plat = new PlateauSize(9, 9);
            var expected = new Plateau(plat);
            Assert.That(expected.IsWithinPlateauSize(plat.length, plat.height), Is.True);
        }
        [Test]
        public void PlateauParser_Return5x5_Withinputx5y5()
        {
            var plat = InputParser.PlateauParser("5 5");
            var expected = new Plateau(plat);
            Assert.That(expected.IsWithinPlateauSize(plat.length, plat.height), Is.True);
        }
        [Test]
        public void PlateauParser_Return15x15y_Withinputx15y5()
        {
            var plat = new PlateauSize(15, 5);
            Assert.Throws<ArgumentOutOfRangeException>(() => { var expected = new Plateau(plat); });
        }
        [Test]
        public void PlateauParser_Returnx5y15_Withinputx5y15()
        {
            var plat = new PlateauSize(5, 15);
            Assert.Throws<ArgumentOutOfRangeException>(() => { var expected = new Plateau(plat); });
        }
        [Test]
        public void PlateauParser_ReturnNull_Withinputx15y15()
        {
            var plat = new PlateauSize(15, 15);
            Assert.Throws<ArgumentOutOfRangeException>(() => { var expected = new Plateau(plat); });
        }
    }
}
