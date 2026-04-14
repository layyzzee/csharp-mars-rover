using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class UserInterface
    {
        public static Plateau gamePlateau;
        public static Rover myRover;

        public static void WelcomeUser()
        {
            Console.WriteLine("Hello, and welcome to this Mars Rover project.\nWe are expecting to touchdown very soon! Although we dont know exactly where.");
        }
        public static PlateauSize? PromptForPlateauSize()
        {
            Console.WriteLine("Please input the PlateauSize in the format:\nX-coordinate Y-coordinate");
            var input = Console.ReadLine();
            var result = InputParser.PlateauParser(input);
            gamePlateau = new Plateau(result);
            return result;
        }
        public static Position? PromptForRoverLandingPosition()
        {
            Console.WriteLine("Please input the landing co-ordinates, and which direction you'd like to face (North, South, East or West) in the format:\nX-coordinate Y-coordinate Direction");
            var input = Console.ReadLine();
            var result = InputParser.StartingPointParser(input);
            Rover myRover = new Rover(result);
            return result;
        }
        public static List<Instruction>? PromptForRoverInstructions()
        {
            Console.WriteLine("Please input the rover instructions you'd like to give (Left, Right or Move) in the format:\n'LMRM'");
            var input = Console.ReadLine();
            var result = InputParser.InstructionParser(input);
            myRover.Move(result) = result;
            return result;
        }
    }
}
