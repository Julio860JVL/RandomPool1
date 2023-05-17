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
            // Then passing the name to this file took me another 3 hours because I did not knew how to do it.

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
                        Choose.Started(player01, player02);
                        break;
                    case "2":
                        //player02.GoesFirst(true); <-- this is not needed because the next
                        // class does not evaluates if 'player02.GoesFirst(true)'.
                        Choose.Started(player01, player02);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: \"005\".");
                Invalid.SelectionWarning();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Select which player goes first between 1 and 2 or select 0 to quit the game.");
                Console.ResetColor();
                FirstToPlay(player01, player02);
            }
        }

        public static string firstToPlay;
        public static string secondToPlay;
        public static void Started(PlayerClass player01, PlayerClass player02)
        {
            if (player01.goesFirst == true)
            {
                ChangeColor.Green(player01.name);
                Console.WriteLine(" is playing first.\n");
                firstToPlay = player01.name;
                secondToPlay = player02.name;
                Game.PoolTable();
            }
            else
            {
                ChangeColor.Green(player02.name);
                Console.WriteLine(" is playing first.\n");
                firstToPlay = player02.name;
                secondToPlay = player01.name;
                Game.PoolTable();
            }
        }
    }
}
