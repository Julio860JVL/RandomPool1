using System;

namespace RandomPool1
{
    internal class ChangeColor
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
}
