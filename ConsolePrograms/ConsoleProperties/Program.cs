using System;

namespace ConsoleProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            AboutConsoleColors();

            Console.WriteLine("\nEnd!");
            Console.ReadKey();

            AboutCursorTop();
            AbboutCursorLeft();
            AboutMethod_SetCursorPosition();
            AboutWindowTop();
            AboutHeightAndWidthConsole();
            AboutConsoleColors();
        }

        private static void AboutConsoleColors()
        {
            // ColorsWithNumbers:
            // 0: Black,
            // 1: DarkBlue
            // 2: DarkGreen
            // 3: DarkCyan
            // 4: DarkRed
            // 5: DarkMagenta
            // 6: DarkYellow
            // 7: Gray
            // 8: DarkGray
            // 9: Blue
            // 10: Green
            // 11: Cyan
            // 12: Red
            // 13: Magenta
            // 14: Yellow
            // 15: White

            //------------------ ForegroundColor ---------------------
            // Get-inde textin hansi rengde oldugunu qaytarir.
            Console.Write("ForegroundColor default deyeri: ");
            Console.WriteLine($"ForegroundColor = {Console.ForegroundColor}");
            // Set-inde textin rengini yuxaridaki siyahidan bir rengi
            // ConsoleColor enum-i uzerinden gondererek deyisir.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ForegroundColor-in deyeri Blue-ye deyisdirildi: ");
            Console.WriteLine($"ForegroundColor = {Console.ForegroundColor}");
            // Cast ederek de etmet olara
            Console.ForegroundColor = (ConsoleColor)1;
            Console.Write("ForegroundColor-in deyeri casting ile 1-e deyisdirildi: ");
            Console.WriteLine($"ForegroundColor = {Console.ForegroundColor}");

            //------------------ BackgroundColor ---------------------
            // Get-inde arxa fonun hansi rengde oldugunu qaytarir.
            Console.Write("BackgroundColor default deyeri: ");
            Console.WriteLine($"BackgroundColor = {Console.BackgroundColor}");
            // Set-inde arxa fonun rengini yuxaridaki siyahidan bir rengi
            // ConsoleColor enum-i uzerinden gondererek deyisir.
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("BackgroundColor-in deyeri Gray-e deyisdirildi: ");
            Console.WriteLine($"BackgroundColor = {Console.BackgroundColor}");
            // Cast ederek de etmet olara
            Console.BackgroundColor = (ConsoleColor)14;
            Console.Write("BackgroundColor-in deyeri casting ile 14-e deyisdirildi: ");
            Console.WriteLine($"BackgroundColor = {Console.BackgroundColor}");
        }

        private static void AboutHeightAndWidthConsole()
        {
            //------------------ LargestWindowHeight ---------------------
            // Ancaq Get mumkundur ve pencerenin Height olcusunu qaytarir.
            Console.WriteLine($"LargestWindowHeight: {Console.LargestWindowHeight}");


            //------------------ LargestWindowWidth ---------------------
            // Ancaq Get mumkundur ve pencerenin Width olcusunu qaytarir.
            Console.WriteLine($"LargestWindowWidth: {Console.LargestWindowWidth}");


            //------------------ BufferHeight ---------------------
            // Mac-da ancaq Get mumkundur ve pencerenin Height olcusunu qaytarir.
            Console.WriteLine($"BufferHeight: {Console.BufferHeight}");


            //------------------ BufferWidth ---------------------
            // Mac-da ancaq Get mumkundur ve pencerenin Width olcusunu qaytarir.
            Console.WriteLine($"BufferWidth: {Console.BufferWidth}");


            //------------------ WindowHeight ---------------------
            // Mac-da ancaq Get mumkundur ve pencerenin Height olcusunu qaytarir.
            Console.WriteLine($"WindowHeight: {Console.WindowHeight}");


            //------------------ WindowWidth ---------------------
            // Mac-da ancaq Get mumkundur ve pencerenin Width olcusunu qaytarir.
            Console.WriteLine($"WindowWidth: {Console.WindowWidth}");


        }

        private static void AboutWindowTop()
        {

            //------------------ WindowTop ---------------------
            // Mac-de ancaq get-i mumkundur: o da 0 qaytarir;
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\n");
            int windowTop = Console.WindowTop;
            Console.WriteLine($" WindowTop {Console.WindowTop}");

            Console.WriteLine(" Novbeti Test --->");
            Console.ReadKey();
            Console.Clear();
        }

        private static void AboutMethod_SetCursorPosition()
        {
            //------------------- SetCursorPosition() ---------------------
            // Arqument olaraq int type-inda
            // 1. CursorLeft ve 2. CursorTop deyer qebul edir,
            // ve o deyerleri adlarina uygun parametirlere beraber edir.
            // Bununlada Cursorun pozisiyasini deyisir.

            Console.WriteLine($"Top: {Console.CursorTop}, " +
                $"Left: {Console.CursorLeft}");
            Console.Write($"Top: {Console.CursorTop}, " +
                $"Left: {Console.CursorLeft} >> ");
            Console.ReadLine();
            Console.WriteLine($"Top: {Console.CursorTop}, " +
                $"Left: {Console.CursorLeft} used method -->");
            Console.SetCursorPosition(15,10);
            Console.Write($"Top: {Console.CursorTop}, " +
                $"Left: {Console.CursorLeft} >> ");
            Console.ReadLine();
            Console.WriteLine($"Top: {Console.CursorTop}, " +
                $"Left: {Console.CursorLeft}");

            Console.WriteLine("\n Novbeti Test --->");
            Console.ReadKey();
            Console.Clear();
        }

        private static void AbboutCursorLeft()
        {
            //-------------------CursorLeft---------------------
            // Get-i kursorun left(sol)-den nece setir sagda oldugunu qaytarir.
            int cursorFromLeft = Console.CursorLeft;
            Console.WriteLine($" CursorLeft1: {cursorFromLeft}");
            Console.Write($"0, 1, 2, 3, 4, ");
            Console.Write($" CursorLeft2: {Console.CursorLeft}\n");

            // Set-de ise kursoru leftden(soldan) nece setir saga qoymaq istediyin yeri yazirsan.
            Console.CursorLeft = 50;
            //Console.ReadLine();

            cursorFromLeft = Console.CursorLeft;
            Console.Write($" CursorLeft3: {cursorFromLeft}");
            Console.Write($" >>fromLeft: {Console.CursorLeft}<<\n");
            Console.ReadLine();

            Console.WriteLine(" Novbeti Test --->");
            Console.ReadKey();
            Console.Clear();
        }

        private static void AboutCursorTop()
        {
            //-------------------CursorTop---------------------
            // Get-i kursorun topdan nece setir asgida oldugunu qaytarir.
            int cursorFromTop = Console.CursorTop;
            Console.WriteLine($" CursorTop1: {cursorFromTop}");

            Console.WriteLine(" =====2-ci setir==== ");
            Console.WriteLine(" =====3-cu setir==== ");
            Console.WriteLine(" =====4-cu setir====m ");
            Console.WriteLine($" CursorTop2: {Console.CursorTop}");
            // Set-de ise kursoru topdan nece setir asaga qoymaq istediyin yeri yazirsan.
            Console.CursorTop = 7;
            Console.ReadKey();

            Console.CursorTop = 4;
            Console.ReadKey();

            Console.ReadLine();

            Console.WriteLine("1 setir asagi");
            cursorFromTop = Console.CursorTop;
            Console.WriteLine($" CursorTop3: {cursorFromTop}");
            Console.ReadLine();


            Console.WriteLine(" Novbeti Test --->");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
