using System;
namespace AbstractionLesson
{
    public class YellowLamp:Lamp
    {
        public YellowLamp()
        {
        }

        public override void TurnOn()
        {

            //Console.Write("Turn On Yellow Light-> ");
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.BackgroundColor = (ConsoleColor)(-1);
        }

        public void YellowLampMethod()
        {
            Console.WriteLine("This method only in Yellow Lamp!");
        }
    }
} 
