using System;
using System.Collections.Generic;

namespace RandomPool1
{
    internal class Select2
    {
        public static void Player2(ListOfPlayerNames listOfPlayersInstance, PlayerClass player01)
        {
            AccessPlayerList(listOfPlayersInstance, player01);

            void AccessPlayerList(ListOfPlayerNames playersToSelect, PlayerClass player1)
            {
                List<string> playerNames = playersToSelect.playerNames;
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

                    if (validatedInput >= listOfPlayersInstance.playerNames.Count)
                    {
                        Console.WriteLine("Error: \"001\" Select Player 2.");
                        Invalid.SelectionWarning();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Select the second player between 1 and 5 or select 0 to quit the game.");
                        Console.ResetColor();
                        Player2(listOfPlayersInstance, player01);
                    }
                    else
                    {
                        string playerName = listOfPlayersInstance.playerNames[validatedInput];
                        Console.WriteLine($"{playerName} has been choosen as player # 2.");
                        Console.WriteLine("");//Just a spacing to make the app easier to read.

                        PlayerClass player02 = new PlayerClass(listOfPlayersInstance.playerNames[validatedInput]);
                        listOfPlayersInstance.playerNames.Remove(playerName);

                        Choose.FirstToPlay(player01, player02);
                    }
                }
                else
                {
                    Console.WriteLine("Error: \"002\" Select Player 2.");
                    Invalid.SelectionWarning();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select the second player between 1 and 5 or select 0 to quit the game.");
                    Console.ResetColor();
                    Player2(listOfPlayersInstance, player01);
                }
            }
        }
    }
}
