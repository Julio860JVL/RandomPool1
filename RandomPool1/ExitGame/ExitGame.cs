using System;

namespace RandomPool1
{
    internal class ExitGame
    {
        public static void ExitTheGame()
        {
            Console.WriteLine("Your selection was to stop the game.");
            Console.WriteLine("Are you sure you want to quit the game? \n(1) Yes | (2) No");

            byte.TryParse(Console.ReadLine(), out byte exitGame);
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
                        RandomPool1.Intro();
                        break;
                }
            }
            else
            {
                Invalid.SelectionWarning();
                ChangeColor.Red("Please select 1 to quit the game or 2 to continue playing.\n");

                ExitTheGame();
            }
        }
    }
}
