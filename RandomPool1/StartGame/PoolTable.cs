using System;
using System.Collections.Generic;
using System.Threading;

namespace RandomPool1
{
    internal class Game
    {
        private static readonly Random FirstPlayerChanceToMiss = new Random();
        private static readonly Random SecondPlayerChanceToMiss = new Random();

        public static void PoolTable()
        {
            List<string> balls = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Array missed = new byte[] { 1, 2, 3, 4, 5 }; //<-- 1 chance out of 5 to missed the shot and pass the turn.
                                                         // Professional players barely miss in real life but I will
                                                         // leave it like that to give the game a little bit of more
                                                         // variations while seeing the game running.
            Console.Write($"There is a total of ");
            ChangeColor.Green($"{balls.Count} balls");
            Console.WriteLine(" on the table.");
            foreach (string i in balls)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.....");
            Console.ReadLine();
            FirstPlayerTurn();

            void FirstPlayerTurn()
            {
                int randomIndex1 = FirstPlayerChanceToMiss.Next(0, missed.Length);
                
                if (randomIndex1 != 4) //<-- # 4 = missed the shot, so pass the turn.
                {
                    string ballPocketed = balls[0];
                    balls.RemoveAt(0);

                    Console.Write($"{Choose.firstToPlay} has ");
                    ChangeColor.Green("pocketed");
                    Console.Write($" the ball # ");
                    ChangeColor.Green(ballPocketed);
                    Console.WriteLine(".");

                    Console.WriteLine($"{balls.Count} balls remaining.");

                    if (balls.Count == 0)
                    {
                        ChangeColor.Green($"{Choose.firstToPlay} has won the game!\n\n");
                    }
                    else
                    {
                        Console.Write(" ---> ");
                        foreach (string i in balls)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine("<---");
                        Console.WriteLine($"{Choose.firstToPlay} is playing again...");
                        Console.WriteLine();
                        Thread.Sleep(2500);

                        FirstPlayerTurn();
                    }
                }
                else
                {
                    string ballMissed = balls[0];
                    Console.Write($"{Choose.firstToPlay} has ");
                    ChangeColor.Red("missed");
                    Console.Write($" the ball # ");
                    ChangeColor.Red(ballMissed);
                    Console.WriteLine(".");

                    ChangeColor.Green($"It is {Choose.secondToPlay}'s turn to play.\n");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    SecondPlayerTurn();
                }
            }

            void SecondPlayerTurn()
            {
                int randomIndex2 = SecondPlayerChanceToMiss.Next(0, missed.Length);
                
                if (randomIndex2 != 4) //<-- # 4 = missed the shot, so pass the turn.
                {
                    string ballPocketed = balls[0];
                    balls.RemoveAt(0);

                    Console.Write($"{Choose.secondToPlay} has ");
                    ChangeColor.Green("pocketed");
                    Console.Write($" the ball # ");
                    ChangeColor.Green(ballPocketed);
                    Console.WriteLine(".");

                    Console.WriteLine($"{balls.Count} balls remaining.");

                    if (balls.Count == 0)
                    {
                        ChangeColor.Green($"{Choose.secondToPlay} has won the game!\n\n");
                    }
                    else
                    {
                        Console.Write(" ---> ");
                        foreach (string i in balls)
                        {
                            Console.Write(i + ", ");
                        }
                        Console.WriteLine("<---");
                        Console.WriteLine($"{Choose.secondToPlay} is playing again...");
                        Console.WriteLine();
                        Thread.Sleep(2500);

                        SecondPlayerTurn();
                    }
                }
                else
                {
                    string ballMissed = balls[0];
                    Console.Write($"{Choose.secondToPlay} has ");
                    ChangeColor.Red("missed");
                    Console.Write($" the ball # ");
                    ChangeColor.Red(ballMissed);
                    Console.WriteLine(".");

                    ChangeColor.Green($"It is {Choose.firstToPlay}'s turn to play.\n");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    FirstPlayerTurn();
                }
            }
            Console.WriteLine("The code has reached the end.");
            Console.WriteLine("Press enter to return to the beginning.");
            Console.ReadLine();

            RandomPool1.Intro();
        }
    }
}
