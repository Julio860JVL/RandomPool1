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
                PoolTable();
            }
            else
            {
                Console.WriteLine($"{player02.name} is playing first.");
                PoolTable();
            }
        }
        public static void PoolTable()
        {
            List<string> balls = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Array missed = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The code has reached the PoolTable.");
            Console.WriteLine("Press any key and it will go back to the beginning.");
            Console.ReadLine();
            RandomPool1.StartGame();
        }
    }
}
