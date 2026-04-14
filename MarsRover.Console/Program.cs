namespace MarsRover.Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface.WelcomeUser();
            UserInterface.PromptForPlateauSize();
            UserInterface.PromptForRoverLandingPosition();
            UserInterface.PromptForRoverInstructions();
            Console.WriteLine();

        }
    }
}
