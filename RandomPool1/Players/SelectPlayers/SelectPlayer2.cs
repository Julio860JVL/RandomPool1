using System;
using System.Collections.Generic;

namespace RandomPool1
{
    internal class Select2
    {
        public static void Player2(ListOfPlayerNames listOfPlayersInstance, PlayerClass player01)
        {
            AccessPlayerList(listOfPlayersInstance);

            void AccessPlayerList(ListOfPlayerNames playersToSelect)
            {
                List<string> playerNames = playersToSelect.PlayerNames;
                Console.WriteLine("Choose player # 2:");
                for (int i = 0; i < playerNames.Count; i++)
                {
                    Console.WriteLine($"{i}: {playerNames[i]}");
                }

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
                        Console.WriteLine("Error: \"003\" Select Player 2.");
                        Invalid.SelectionWarning();
                        ChangeColor.Red("Select the second player between 1 and 5 or select 0 to quit the game.\n");
                        Player2(listOfPlayersInstance, player01);
                    }
                    else
                    {
                        string playerName = listOfPlayersInstance.PlayerNames[validatedInput];
                        ChangeColor.Green(playerName);
                        Console.WriteLine(" has been choosen as player # 2.\n");

                        PlayerClass player02 = new PlayerClass(listOfPlayersInstance.PlayerNames[validatedInput]);
                        //listOfPlayersInstance.PlayerNames.Remove(playerName);

                        Choose.FirstToPlay(player01, player02);
                    }
                }
                else
                {
                    Console.WriteLine("Error: \"004\" Select Player 2.");
                    Invalid.SelectionWarning();
                    ChangeColor.Red("Select the second player between 1 and 5 or select 0 to quit the game.\n");
                    Player2(listOfPlayersInstance, player01);
                }
            }
        }
    }
}
