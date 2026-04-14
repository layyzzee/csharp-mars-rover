using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class UserInterface
    {
        public  Plateau? gamePlateau;
        public  Rover? myRover;
        public Rover? otherRover;
        public bool isRunning = true;

        public UserInterface()
        {
            gamePlateau = null;
            myRover = null;
        }

        public bool GameOver()
        {
            bool collision = (myRover.CurrentPosition.XCoord == otherRover.CurrentPosition.XCoord) && (myRover.CurrentPosition.YCoord == myRover.CurrentPosition.YCoord);            
                isRunning = !collision;
            Console.WriteLine("Game Over");
                return collision;            
        }

        public void WelcomeUser()
        {
            Console.WriteLine("Hello, and welcome to this Mars Rover project.\nWe are expecting to touchdown very soon! Although we dont know exactly where.");
        }
        public  void PromptForPlateauSize()
        {
            Console.WriteLine("Please input the PlateauSize with positive values up to 10 in the format:\nX-coordinate Y-coordinate");
            var input = Console.ReadLine();
            try
            {
                var result = InputParser.PlateauParser(input);
                gamePlateau = new Plateau(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                gamePlateau = null;
                Console.WriteLine("Invalid input, please make sure you input a value for both X and Y coordinates");
            }
            catch (ArgumentNullException)
            {
                gamePlateau = null;
                Console.WriteLine("Null input is not allowed, please try again");
            }
            catch (Exception ex)
            {
                gamePlateau = null;
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        public void PromptForRoverLandingPosition()
        {
            Console.WriteLine($"The current plateau's dimensions are:\nLength {gamePlateau.Length}, and Height {gamePlateau.height}");
            Console.WriteLine("Please input the landing co-ordinates, and which direction\nyou'd like to face (N, S, E or W) in the format:\n" +
                "X-coordinate Y-coordinate Direction");
            var input = Console.ReadLine();
            try
            {
                var result = InputParser.StartingPointParser(input);
                if (result == null) throw new ArgumentOutOfRangeException();
                if(result.XCoord > gamePlateau.Length || result.YCoord > gamePlateau.height)
                {
                    myRover = null;
                    Console.WriteLine("The specified co-ordinates were outside of the plateau, please try again");
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    myRover = new Rover(result);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                myRover = null;
            }
            catch (NullReferenceException)
            {
                myRover = null;
            }
            catch (Exception ex)
            {
                myRover = null;
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }

        }
        public void PromptForRoverInstructions()
        {
            Console.WriteLine($"The current plateau's dimensions are:\nLength {gamePlateau.Length}, and Height {gamePlateau.height}");
            Console.WriteLine($"The current rover position is:\n{myRover.CurrentPosition.XCoord}, {myRover.CurrentPosition.YCoord}, facing {myRover.CurrentPosition.Direction}");
            Console.WriteLine("Please input the rover instructions you'd like to give (Left, Right or Move) in the format:\n'LMRM'");
            var input = Console.ReadLine();
            var oldPosition = myRover.CurrentPosition;
            try
            {
                var nextPosition = myRover.CurrentPosition;
                var result = InputParser.InstructionParser(input);
                myRover.Drive(result);
                if (myRover.CurrentPosition.XCoord <= gamePlateau.Length || myRover.CurrentPosition.YCoord <= gamePlateau.height)
                {
                    Console.WriteLine($"You successfully moved from {oldPosition.XCoord},{oldPosition.YCoord} facing {oldPosition.Direction} to " +
                        $"{myRover.CurrentPosition.XCoord},{myRover.CurrentPosition.YCoord} facing {myRover.CurrentPosition.Direction} with a registered input of {result}");
                }
                else
                {
                    myRover.CurrentPosition = oldPosition;
                    Console.WriteLine("The specified co-ordinates were outside of the plateau, please try again.");
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
               
            }
            catch (ArgumentException)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        public void GenerateSpacePirates()
        {
            Random rand = new Random();
            Position randPos;
            do
            {
                var x = rand.Next(0, gamePlateau.Length);
                var y = rand.Next(0, gamePlateau.height);
                randPos = new Position(x, y, Compass.N);
            }
            while (myRover.CurrentPosition.XCoord == randPos.XCoord && myRover.CurrentPosition.YCoord == randPos.YCoord);
            otherRover = new Rover(randPos);
        }
    }
}
