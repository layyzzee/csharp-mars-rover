using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Terminal;

namespace MarsRover.Test
{
    internal class IntegrationTests
    {
        [Test]
        public void IntegrationTest1_Returns13N_WhenInput12NAndLMLMLMLMM()
        {
            var plateauInts = "5 5";
            var startingPos1 = "1 2 N";
            var movements1 = "LMLMLMLMM";
            var parsedPlateau = InputParser.PlateauParser(plateauInts);
            var parsedStartingPos1 = InputParser.StartingPointParser(startingPos1);
            var parsedMovements1 = InputParser.InstructionParser(movements1);
            var rover1 = new Rover(parsedStartingPos1);
            rover1.Drive(parsedMovements1);
            Assert.That(rover1.CurrentPosition.XCoord, Is.EqualTo(1));
            Assert.That(rover1.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover1.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
        [Test]
        public void IntegrationTest2_Returns51E_WhenInput33EMMRMMRMRRM()
        {
            var plateauInts = "5 5";
            var startingPos2 = "3 3 E";
            var movements2 = "MMRMMRMRRM";
            var parsedPlateau = InputParser.PlateauParser(plateauInts);
            var parsedStartingPos2 = InputParser.StartingPointParser(startingPos2);
            var parsedMovements2 = InputParser.InstructionParser(movements2);
            var rover2 = new Rover(parsedStartingPos2);
            rover2.Drive(parsedMovements2);
            Assert.That(rover2.CurrentPosition.XCoord, Is.EqualTo(5));
            Assert.That(rover2.CurrentPosition.YCoord, Is.EqualTo(1));
            Assert.That(rover2.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
    }
}
