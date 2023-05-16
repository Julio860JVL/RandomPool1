using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RandomPool1
{
    internal class ColorTo
    {
        public static string Red(string a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(a);
            Console.ResetColor();
            return a;
        }
        public static string Green(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(a);
            Console.ResetColor();
            return a;
        }
    }
    internal class Game
    {
        private static string firstToPlay;
        private static string secondToPlay;
        private static readonly Random FirstPlayerChanceToMiss = new Random();
        private static readonly Random SecondPlayerChanceToMiss = new Random();
        public static void Started(PlayerClass player01, PlayerClass player02)
        {
            if (player01.goesFirst == true)
            {
                Console.WriteLine($"{player01.name} is playing first.");
                firstToPlay = player01.name;
                secondToPlay = player02.name;
                PoolTable();
            }
            else
            {
                Console.WriteLine($"{player02.name} is playing first.");
                firstToPlay = player02.name;
                secondToPlay = player01.name;
                PoolTable();
            }
        }
        public static void PoolTable()
        {
            List<string> balls = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Array missed = new byte[] { 1, 2, 3, 4, 5 }; //<-- # 4 = missed the shot.
            Console.WriteLine($"There is a total of {balls.Count} balls on the table.");
            foreach (string i in balls)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            FirstPlayerTurn();

            void FirstPlayerTurn()
            {
                int randomIndex1 = FirstPlayerChanceToMiss.Next(0, missed.Length);
                
                if (randomIndex1 != 4) //<-- # 4 = missed the shot, so pass the turn.
                {
                    string ballPocketed = balls[0];
                    balls.RemoveAt(0);
                    Console.Write($"{firstToPlay} has ");
                    ColorTo.Green("pocketed");
                    Console.Write(" the ball # ");
                    ColorTo.Green($"{ballPocketed}.");
                    Console.WriteLine();
                    Console.WriteLine($"{balls.Count} balls remaining.");
                    Console.Write(" ---> ");

                    if (balls.Count == 0)
                    {
                        ColorTo.Green($"{firstToPlay} has won the game!\n");
                    }
                    else
                    {
                        foreach (string i in balls)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine("<---");
                        Console.WriteLine($"{firstToPlay} is playing again...");
                        Console.WriteLine();
                        Thread.Sleep(2500);
                        FirstPlayerTurn();
                    }
                }
                else
                {
                    string ballMissed = balls[0];
                    Console.Write($"{firstToPlay} has ");
                    ColorTo.Red("missed");
                    Console.Write(" the ball # ");
                    ColorTo.Red($"{ballMissed}");
                    Console.WriteLine();
                    Console.WriteLine($"It is {secondToPlay} turn to play.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    SecondPlayerTurn();
                }
            }

            void SecondPlayerTurn()
            {
                int randomIndex1 = SecondPlayerChanceToMiss.Next(0, missed.Length);
                
                if (randomIndex1 != 4) //<-- # 4 = missed the shot, so pass the turn.
                {
                    string ballPocketed = balls[0];
                    balls.RemoveAt(0);
                    Console.Write($"{secondToPlay} has ");
                    ColorTo.Green("pocketed");
                    Console.Write(" the ball # ");
                    ColorTo.Green($"{ballPocketed}.");
                    Console.WriteLine();
                    Console.WriteLine($"{balls.Count} balls remaining.");
                    Console.Write(" ---> ");

                    if (balls.Count == 0)
                    {
                        ColorTo.Green($"{secondToPlay} has won the game!\n");
                    }
                    else
                    {
                        foreach (string i in balls)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine("<---");
                        Console.WriteLine($"{secondToPlay} is playing again...");
                        Console.WriteLine();
                        Thread.Sleep(2500);
                        SecondPlayerTurn();
                    }
                }
                else
                {
                    string ballMissed = balls[0];
                    Console.Write($"{secondToPlay} has ");
                    ColorTo.Red("missed");
                    Console.Write(" the ball # ");
                    ColorTo.Red($"{ballMissed}");
                    Console.WriteLine();
                    Console.WriteLine($"It is {firstToPlay} turn to play.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    FirstPlayerTurn();
                }
            }
            Console.WriteLine("The code has reached the end.");
            Console.WriteLine("Press enter to return to the beginning.");
            Console.ReadLine();
            RandomPool1.StartGame();
        }
    }
}
