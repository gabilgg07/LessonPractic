using System;
using System.Threading;

namespace ParallelProgrammingCA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Thread thread1 = new Thread(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0");
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("1");
                }
            });

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }
    }
}
