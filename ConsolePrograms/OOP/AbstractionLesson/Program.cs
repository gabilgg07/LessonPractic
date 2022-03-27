using System;
using System.Threading;

namespace AbstractionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Abstraction Lesson ====");

            // Abstract classdan obyekt yaratmaq olmur(xeyali oldugu dusunulmelidir)

            //Phone phone = new Phone();

            Panasonic panasonic = new Panasonic();

            Console.WriteLine("--- Pnasonic ---");
            panasonic.Call();
            panasonic.Answer();
            panasonic.Reject();

            Motorola motorola = new Motorola();

            Console.WriteLine("--- Motorola ---");
            motorola.Call();
            motorola.Answer();
            motorola.Reject();

            //--------------------------------------

            YellowLamp yl = new YellowLamp();

            yl.TurnOn();
            Console.WriteLine();
            yl.YellowLampMethod();
            Console.WriteLine();

            LedLamp ll = new LedLamp();

            ll.TurnOn();
            Console.WriteLine();

            // Bele de yazmaq olur:
            Lamp yellowL = new YellowLamp();

            Console.WriteLine($"Parentden goturulmus: {yellowL.GetType()}");
            yellowL.TurnOn();
            Console.WriteLine();
            // Bele yazanda o zaman obyekt YellowLample ortaq olan
            // Lapin methodlarini YellowLamp kimi istifade ede bilir.
            // YellowLamp-in oz methodlarini gore bilmir.

            //yellowL.YellowLampMethod();

            RepeatingLight(ll);
            Console.WriteLine();
            RepeatingLight(yl);

            Console.ReadKey();
        }

        static void RepeatingLight(Lamp lamp)
        {
            Console.Write("Lamp Repeating Light: ");
            int cursorTop = Console.CursorTop;
            int cursorLeft = Console.CursorLeft;
            int counter = 0;
            while (counter < 10)
            {
                Thread.Sleep(250);
                Console.Write("     ");
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Thread.Sleep(300);
                Console.Write("  ");
                lamp.TurnOn();
                Console.SetCursorPosition(cursorLeft, cursorTop);
                counter++;
            }
            Console.WriteLine();
        }
    }
}
