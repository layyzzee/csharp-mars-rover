namespace MarsRover.Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialising
            var UI = new UserInterface();
            UI.WelcomeUser();
            Thread.Sleep(1000);
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
                Thread.Sleep(1000);
                Console.Clear();
            }
            UI.GenerateSpacePirates();
            while (UI.isRunning)
            {
                UI.PromptForRoverInstructions();
                Thread.Sleep(1000);
                Console.Clear();
                UI.GameOver();
            }




            //var currentAppState = AppState.Welcome;
            //while (true)
            //{
            //    switch (currentAppState)
            //    {
            //        case AppState.Welcome:
            //            UI.WelcomeUser();
            //            currentAppState = AppState.PromptForPlateau;
            //            break;

                //        case AppState.PromptForPlateau:
                //            UI.PromptForPlateauSize();
                //            currentAppState = AppState.PromptForLanding;
                //            break;

                //        case AppState.PromptForLanding:
                //            UI.PromptForRoverLandingPosition();
                //            currentAppState = AppState.PromptForInstructions;
                //            break;

                //        case AppState.PromptForInstructions:
                //            UI.PromptForRoverInstructions();
                //            currentAppState = AppState.DisplayPlateau;
                //            break;

                //        case AppState.DisplayPlateau:
                //            UI.PromptForRoverInstructions();
                //            break;

                //        default:
                //            throw new InvalidOperationException("Unknown application state");
                //    }
                //}


        }
    }
}
