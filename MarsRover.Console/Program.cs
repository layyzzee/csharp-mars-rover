namespace MarsRover.Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            string plateauInput = "10 10";
            string startingPositionInput = "2 5 E";
            string roverMoveInput = "LMLLMRRRRM";

            var gamePlateau = InputParsing.PlateauParser(plateauInput);
            var gameStartPosition = InputParsing.StartingPointParser(startingPositionInput);
            var roverMovement = InputParsing.RoverMovementParse(roverMoveInput);

            Console.WriteLine(gamePlateau);
            Console.WriteLine(gameStartPosition);
            Console.WriteLine(string.Join(", ", roverMovement));

        }
    }
}
