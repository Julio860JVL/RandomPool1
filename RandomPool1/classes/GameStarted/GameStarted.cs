using System;
using System.Collections.Generic;

namespace RandomPool1
{
    internal class Game
    {
        public static void Started(PlayerClass player01, PlayerClass player02)
        {
            if (player01.goesFirst == true)
            {
                Console.WriteLine($"{player01.name} is playing first.");
                Started(player01, player02);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{player02.name} is playing first.");
                Started(player01, player02);
                Console.ReadLine();
            }
        }
        public static void PoolTable()
        {
            List<string> balls = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Array missed = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
