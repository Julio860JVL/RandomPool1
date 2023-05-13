using System;

namespace RandomPool1
{
    public class RandomPool1
    {
        public static void StartGame()
        {
            Console.WriteLine("Do you want to start a Random Pool game? \n(1) Yes | (2) No");

            byte userInput;
            byte.TryParse(Console.ReadLine(), out userInput);

            if (userInput == 1 || userInput == 2)
            {
                switch (userInput)
                {
                    case 1:
                        Select1.Player1();
                        break;
                    case 2:
                        ExitGame.ExitTheGame();
                        break;
                }
            }
            else if (userInput != 1 || userInput != 2)
            {
                Invalid.SelectionWarning();
                StartGame();
            }
        }
    }
}
