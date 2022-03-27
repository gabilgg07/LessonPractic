using System;
namespace AbstractionLesson
{
    public class LedLamp:Lamp
    {
        public LedLamp()
        {
        }

        public override void TurnOn()
        {
            //Console.Write("Turn On Led Light-> ");
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = (ConsoleColor)(-1);
        }
    }
}
