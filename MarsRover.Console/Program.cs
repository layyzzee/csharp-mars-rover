namespace MarsRover.Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            var UI = new UserInterface();
            UI.WelcomeUser();
            Thread.Sleep(2000);
            Console.Clear();
            while (UI.gamePlateau == null)
            {
                UI.PromptForPlateauSize();
                Thread.Sleep(1000);
                Console.Clear();
            }
            while (UI.myRover == null)
            {
                UI.PromptForRoverLandingPosition();
            }
            UI.GenerateSpacePirates();
            Thread.Sleep(2500);
            Console.Clear();
            while (UI.isRunning)
            {
                UI.CheckProximity();
                UI.PromptForRoverInstructions();
                Thread.Sleep(1000);
                Console.Clear();
                UI.GameOver();
            }
        }
    }
}
