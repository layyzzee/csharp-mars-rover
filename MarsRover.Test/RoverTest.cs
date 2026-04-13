using MarsRover.Terminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test
{
    internal class RoverTest
    {
        [Test]
        public void Rotate_NorthToEast_WhenTurningRight()
        {
            var startPos = new Position(0, 0, Compass.N);
            var rover = new Rover(startPos);
            rover.Rotate(Movement.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void Rotate_NorthToSouth_WhenTurningRight()
        {
            var startPos = new Position(0, 0, Compass.E);
            var rover = new Rover(startPos);
            rover.Rotate(Movement.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.S));
        }
        [Test]
        public void Rotate_NorthToWest_WhenTurningRight()
        {
            var startPos = new Position(0, 0, Compass.S);
            var rover = new Rover(startPos);
            rover.Rotate(Movement.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
        [Test]
        public void Rotate_NorthToNorth_WhenTurningRight()
        {
            var startPos = new Position(0, 0, Compass.W);
            var rover = new Rover(startPos);
            rover.Rotate(Movement.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
    }
}
