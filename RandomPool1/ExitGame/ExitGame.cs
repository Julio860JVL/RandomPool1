using System;

namespace RandomPool1
{
    internal class ExitGame
    {
        public static void ExitTheGame()
        {
            Console.WriteLine("Your selection was to stop the game.");
            Console.WriteLine("Are you sure you want to quit the game? \n(1) Yes | (2) No");

            byte exitGame;
            byte.TryParse(Console.ReadLine(), out exitGame);

            if (exitGame == 1 || exitGame == 2)
            {
                switch (exitGame)
                {
                    case 1:
                        Console.WriteLine("Okay! Have a nice day!");
                        Environment.Exit(0); // I did not knew about this line of code.
                                             // I got it from ChatGPT.
                        break;
                    case 2:
                        RandomPool1.StartGame();
                        break;
                }
            }
            else if (exitGame != 1 || exitGame != 2)
            {
                Invalid.SelectionWarning();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please select 1 to quit the game or 2 to continue playing.");
                Console.ResetColor();
                ExitTheGame();
            }
        }
    }
}
