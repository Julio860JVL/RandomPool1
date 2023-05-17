using System;

namespace RandomPool1
{
    internal class Invalid
    {
        public static void SelectionWarning()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid selection.");
            Console.ResetColor();
        }
    }
}