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
        public void MoveForward_ReturnX3Y3_WhenInputX3Y2N()
        {
            var startPos = new Position(3, 2, Compass.N);
            var rover = new Rover(startPos);
            rover.MoveForward(Instruction.M);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }
        [Test]
        public void MoveForward_ReturnX3Y3_WhenInputX3Y4S()
        {
            var startPos = new Position(3, 4, Compass.S);
            var rover = new Rover(startPos);
            rover.MoveForward(Instruction.M);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.S));
        }
        [Test]
        public void MoveForward_ReturnX3Y3_WhenInputX2Y3E()
        {
            var startPos = new Position(2, 3, Compass.E);
            var rover = new Rover(startPos);
            rover.MoveForward(Instruction.M);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void MoveForward_ReturnX3Y3_WhenInputX4Y4W()
        {
            var startPos = new Position(4, 3, Compass.W);
            var rover = new Rover(startPos);
            rover.MoveForward(Instruction.M);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }

        [Test]
        public void Drive_ReturnX3Y3N_WhenInputX3Y2NWithM()
        {
            var startPos = new Position(3,2, Compass.N);
            var rover = new Rover(startPos);
            var input = new List<Instruction> { Instruction.M };
            var result = rover.Drive(input);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(3));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.N));
        }

        [Test]
        public void Drive_ReturnX4Y2E_WhenInputX3Y2NWithRM()
        {
            var startPos = new Position(3, 2, Compass.N);
            var rover = new Rover(startPos);
            var input = new List<Instruction> { Instruction.R, Instruction.M };
            var result = rover.Drive(input);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(4));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(2));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.E));
        }
        [Test]
        public void Drive_ReturnX2Y1N_WhenInputX0Y0NWithList()
        {
            var startPos = new Position(0, 0, Compass.N);
            var rover = new Rover(startPos);
            var input = new List<Instruction> { Instruction.M, Instruction.R, Instruction.M, Instruction.M, Instruction.L, Instruction.L };
            var result = rover.Drive(input);
            Assert.That(rover.CurrentPosition.XCoord, Is.EqualTo(2));
            Assert.That(rover.CurrentPosition.YCoord, Is.EqualTo(1));
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Compass.W));
        }
    }
}
