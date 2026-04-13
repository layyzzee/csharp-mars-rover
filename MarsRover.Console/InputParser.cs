using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class InputParser
    {
        public static Plateau? PlateauParser(string input)
        {
            string[] inputElements = input.Split(' ');
            if (inputElements.Length != 2)
            {
                Console.WriteLine("Invalid arguments, please input in the format: XCoordinate YCoordinate");
                return null;
            }
            if (int.TryParse(inputElements[0], out int xCoord) && int.TryParse(inputElements[1], out int yCoord))
            {
                return new Plateau(xCoord, yCoord);
            }
            return null;
        }

        public static Position? StartingPointParser(string input)
        {
            string[] inputElements = input.Split(' ');
            if (inputElements.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please input in the format: XCoordinate YCoordinate FacingCompassDirection");
                return null;
            }
            Compass? direction = inputElements[2] switch
            {
                "N" => Compass.N,
                "E" => Compass.E,
                "S" => Compass.S,
                "W" => Compass.W,
                _ => null
            };
            if (int.TryParse(inputElements[0], out int x) && int.TryParse(inputElements[1], out int y))
            {
                if (direction != null)
                {
                    return new Position(x, y, direction.Value);
                }
                Console.WriteLine("Invalid Direction Argument, Please Use One Of: N E S W");
                return null;
            }
            Console.WriteLine("Invalid Co-ordinates, Please Use Valid Integers");
            return null;
        }

        public static List<Instruction> InstructionParser(string input)
        {
            var instructionList = new List<Instruction>();
            foreach (char c in input)
            {
                if (Enum.TryParse(c.ToString(), out Instruction instruction))
                {
                    instructionList.Add(instruction);
                }
                else
                {
                    continue;
                }
            }
            if (instructionList.Count == 0)
            {
                throw new ArgumentException("Invalid input format for instructions. Expected characters: 'L', 'R', 'M'");
            }
            return instructionList;
        }
    }
}
