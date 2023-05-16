using System;
using System.Collections.Generic;

namespace RandomPool1
{
    internal class Select1
    {
        public static void Player1()
        {
            ListOfPlayerNames listOfPlayersInstance = new ListOfPlayerNames();
            void ListOfPlayers(ListOfPlayerNames playersToSelect)
            {
                List<string> playerNames = playersToSelect.PlayerNames;

                Console.WriteLine("Choose player # 1:");
                for (int i = 0; i < playerNames.Count; i++)
                {
                    Console.WriteLine($"{i}: {playerNames[i]}");
                }
            }
            ListOfPlayers(listOfPlayersInstance);

            string userInput = Console.ReadLine();
            if (byte.TryParse(userInput, out byte validatedInput))
            {
                switch (validatedInput)
                {
                    case 0:
                        ExitGame.ExitTheGame();
                        break;
                }

                if (validatedInput >= listOfPlayersInstance.PlayerNames.Count)
                {
                    Console.WriteLine("Error: " + 001 + " Select Player 1.");
                    Invalid.SelectionWarning();
                    ChangeColor.Red("Select the first player between 1 and 6 or select 0 to quit the game.\n");
                    Player1();
                }
                else
                {
                    string playerName = listOfPlayersInstance.PlayerNames[validatedInput];
                    Console.WriteLine($"{playerName} has been choosen as player # 1.\n");
                    
                    PlayerClass player01 = new PlayerClass(listOfPlayersInstance.PlayerNames[validatedInput]);
                    listOfPlayersInstance.PlayerNames.Remove(playerName);

                    Select2.Player2(listOfPlayersInstance, player01);
                }
            }
            else
            {
                Console.WriteLine("Error: " + 002 + " Select Player 1.");
                Invalid.SelectionWarning();
                ChangeColor.Red("Select the first player between 1 and 6 or select 0 to quit the game.\n");
                Player1();
            }
        }
    }
}