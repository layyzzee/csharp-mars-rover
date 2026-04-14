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
        public void Rotate_ReturnEast_WhenInputR()
        {
            var startPos = new Position(0, 0, Compass.N);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void Rotate_ReturnSouth_WhenInputR()
        {
            var startPos = new Position(0, 0, Compass.E);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.S));
        }
        [Test]
        public void Rotate_ReturnWest_WhenInputR()
        {
            var startPos = new Position(0, 0, Compass.S);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
        [Test]
        public void Rotate_ReturnNorth_WhenInputR()
        {
            var startPos = new Position(0, 0, Compass.W);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.R);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
        [Test]
        public void Rotate_ReturnWest_WhenInputL()
        {
            var startPos = new Position(0, 0, Compass.N);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.L);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
        [Test]
        public void Rotate_ReturnNorth_WhenInputL()
        {
            var startPos = new Position(0, 0, Compass.E);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.L);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
        [Test]
        public void Rotate_ReturnEast_WhenInputL()
        {
            var startPos = new Position(0, 0, Compass.S);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.L);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void Rotate_ReturnSouth_WhenInputL()
        {
            var startPos = new Position(0, 0, Compass.W);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.L);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.S));
        }
        [Test]
        public void Rotate_ReturnWest_WhenInputM()
        {
            var startPos = new Position(0, 0, Compass.W);
            var rover = new Rover(startPos);
            rover.Rotate(Instruction.M);
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
        [Test]
        public void Move_ReturnX3Y3_WhenInputX3Y2N()
        {
            var startPos = new Position(3, 2, Compass.N);
            var rover = new Rover(startPos);
            rover.MoveForward();
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
        [Test]
        public void Move_ReturnX3Y3_WhenInputX3Y4S()
        {
            var startPos = new Position(3, 4, Compass.S);
            var rover = new Rover(startPos);
            rover.MoveForward();
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.S));
        }
        [Test]
        public void Move_ReturnX3Y3_WhenInputX2Y3E()
        {
            var startPos = new Position(2, 3, Compass.E);
            var rover = new Rover(startPos);
            rover.MoveForward();
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void Move_ReturnX3Y3_WhenInputX4Y4W()
        {
            var startPos = new Position(4, 3, Compass.W);
            var rover = new Rover(startPos);
            rover.MoveForward();
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
    }
}
