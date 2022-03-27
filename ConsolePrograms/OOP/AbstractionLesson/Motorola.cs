using System;
using System.Threading;

namespace AbstractionLesson
{
    public class Motorola: Phone
    {
        public Motorola()
        {
        }

        public override void Call()
        {
            base.Call();
            Console.Write("TurnOnLight: ");
            int counter = 5;
            int cursorTop = Console.CursorTop;
            int cursorLeft = Console.CursorLeft;
            while (counter>0)
            {
                Console.Write("     ");
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Thread.Sleep(250);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Thread.Sleep(150);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(150);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Thread.Sleep(150);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(150);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(150);
                Console.SetCursorPosition(cursorLeft, cursorTop);
                counter--;
            }

            Console.WriteLine();
        }
    }
}
