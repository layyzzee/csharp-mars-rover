using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class InputParsing
    {
        private static Plateau _CurrentPlateau;
        public static Plateau? PlateauParser(string input)     //Should take x y
        {
            string[] inputElements = input.Split(' ');
            if (inputElements.Length != 2)
            {
                Console.WriteLine("Invalid arguments, please input in the format: XCoordinate YCoordinate");
                return null;
            }
            try
            {
                int xCoord = int.Parse(inputElements[0]);
                int yCoord = int.Parse(inputElements[1]);
                if (xCoord > 10 || yCoord > 10)
                {
                    Console.WriteLine("Grid is too big, keep it 10 or under for both X and Y");
                    return null;
                }
                _CurrentPlateau = new Plateau(xCoord, yCoord);
                return new Plateau(xCoord, yCoord);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input Type");
                return null;
            }
        }

        public static Position? StartingPointParser(string input)
        {
            string[] inputElements = input.Split(' ');
            if (inputElements.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please input in the format: XCoordinate YCoordinate FacingCompassDirection");
                return null;
            }
            try
            {
                int xCoord = int.Parse(inputElements[0]);
                int yCoord = int.Parse(inputElements[1]);
                string inputDirection = inputElements[2];
                Compass? direction = inputDirection switch
                {
                    "N" => Compass.N,
                    "E" => Compass.E,
                    "S" => Compass.S,
                    "W" => Compass.W,
                    _ => null
                };
                if (xCoord > _CurrentPlateau.Length|| yCoord > _CurrentPlateau.Height)
                {
                    Console.WriteLine("Starting Point is Outside the Current Plateau");
                    return null;
                }
                if (direction != null)
                {
                    return new Position(xCoord, yCoord, direction.Value);
                }
                Console.WriteLine("Invalid Direction Argument, Please Use One Of: N E S W");
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input Type");
                return null;
            }
        }

        public static void MoveRover(string input)
        {

        }
    }
}
