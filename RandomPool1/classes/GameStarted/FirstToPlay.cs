using System;

namespace RandomPool1
{
    internal class Choose
    {
        public static void FirstToPlay(PlayerClass player01, PlayerClass player02)
        {
            Console.WriteLine("Choose which player goes first.");
            Console.WriteLine("(0) Exit Game\n(1) " + player01.name + " VS (2) " + player02.name);
            // The player selection took me 6 hours.
            // Then passing the name to this file took me another 3 hours.

            string userInput = Console.ReadLine();

            if (userInput == "0" || userInput == "1" || userInput == "2")
            {
                switch (userInput)
                {
                    case "0":
                        ExitGame.ExitTheGame();
                        FirstToPlay(player01, player02);
                        break;
                    case "1":
                        player01.goesFirst = true;
                        Console.WriteLine("");//Just a spacing to make the app easier to read.
                        Game.Started(player01, player02);
                        break;
                    case "2":
                        //player02.GoesFirst(true); <-- this is not needed because the next
                        // class does not evaluates if 'player02.GoesFirst(true)'.
                        Game.Started(player01, player02);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Error: \"001\".");
                Invalid.SelectionWarning();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Select which player goes first between 1 and 2 or select 0 to quit the game.");
                Console.ResetColor();
                FirstToPlay(player01, player02);
            }
        }
    }
}
