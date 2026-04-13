using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class InputParsing
    {
        public static Plateau? PlateauParser(string input)     //Should take x y
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

        public static Position? StartingPointParser(string input) //Should take x y d
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
            if (int.TryParse(inputElements[0], out int xCoord) && int.TryParse(inputElements[1], out int yCoord))
            {
                if (direction != null)
                {
                    return new Position(xCoord, yCoord, direction.Value);
                }
                Console.WriteLine("Invalid Direction Argument, Please Use One Of: N E S W");
                return null;
            }
            Console.WriteLine("Invalid Co-ordinates, Please Use Valid Integers");
            return null;
        }

        public static List<Movement>? RoverMovementParse(string input) //Should take LMRM string
        {
            var movementList = new List<Movement>();
            foreach(char c in input.ToUpper())
            {
                switch (c)
                {
                    case 'L': movementList.Add(Movement.L); break;
                    case 'R': movementList.Add(Movement.R); break;
                    case 'M': movementList.Add(Movement.M); break;
                    default: continue;
                }
            }
            if (movementList.Count > 0)
            {
                return movementList;
            }
            return null;
        }
    }
}
