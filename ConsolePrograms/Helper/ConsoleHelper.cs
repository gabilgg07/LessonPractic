using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Helper
{
    static public class ConsoleHelper
    {
        /// <summary>
        /// Culture-ni Azərbaycan dilinə keçirir.
        /// </summary>
        static public void SetDefaults()
        {
            CultureInfo ci = new CultureInfo("az");
            ci.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            ci.DateTimeFormat.LongDatePattern = "dd.MM.yyyy";
            ci.DateTimeFormat.ShortTimePattern = "HH:mm";
            ci.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            ci.DateTimeFormat.FullDateTimePattern = "dd.MM.yyyy HH:mm:ss";
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = ci;

            Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;
        }

        /// <summary>
        /// Get integer number from console.
        /// Requires repetition until you write the correct integer.
        /// </summary>
        /// <returns>Intager number</returns>
        public static int GetIntNumFromConsole()
        {
            l1:
            Console.Write("\n Write a integer number: ");
            string numStr = Console.ReadLine();
            int num;
            if (!int.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not a integer number, try again.. ");
                goto l1;
            }

            return num;
        }

        public static int GetIntNumFromConsole(string message = "\n Write a integer number: ")
        {
        l1:
            Console.Write(message);
            string numStr = Console.ReadLine();
            int num;
            if (!int.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not a integer number, try again.. ");
                goto l1;
            }

            return num;
        }

        public static int GetIntNumFromConsole(string message = "\n Write a integer number: ", string errorMessge = "is not a integer number, try again.. ")
        {
        l1:
            Console.Write(message);
            string numStr = Console.ReadLine();
            int num;
            if (!int.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} {errorMessge}");
                goto l1;
            }

            return num;
        }


        /// <summary>
        /// Get byte number from console.
        /// Requires repetition until you write the correct byte number.
        /// </summary>
        /// <returns>Byte number</returns>
        public static byte GetByteNumFromConsole()
        {
        l1:
            Console.Write("\n Write a number of byte: ");
            string numStr = Console.ReadLine();
            byte num;
            if (!byte.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not a byte number, try again.. ");
                goto l1;
            }

            return num;
        }

        public static byte GetByteNumFromConsole(string message = "\n Write a number of byte: ", string errorMessage = "a byte number")
        {
        l1:
            Console.Write(message);
            string numStr = Console.ReadLine();
            byte num;
            if (!byte.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not {errorMessage}, try again.. ");
                goto l1;
            }

            return num;
        }

        /// <summary>
        /// Get double number from console.
        /// Requires repetition until you write the correct a rational number.
        /// </summary>
        /// <returns>Double number</returns>
        public static double GetDoubleNumFromConsole()
        {
        l1:
            Console.Write("\n Write a rational number: ");
            string numStr = Console.ReadLine();
            double num;
            if (!double.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not a rational number, try again.. ");
                goto l1;
            }

            return num;
        }

        public static double GetDoubleNumFromConsole(string message = "\n Write a rational number: ")
        {
        l1:
            Console.Write(message);
            string numStr = Console.ReadLine();
            double num;
            if (!double.TryParse(numStr, out num))
            {
                Console.WriteLine($"\n>> {numStr} is not a rational number, try again.. ");
                goto l1;
            }

            return num;
        }

        /// <summary>
        /// Get string (non-empty) from Console.
        /// Requires repetition until you write the string(non-empty).
        /// </summary>
        /// <returns>string</returns>
        public static string GetStringFromConsole()
        {
        l1:
            Console.Write("\n Write a string: ");
            string str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("\n>> Can not be empty, try again.. ");
                goto l1;
            }

            return str;
        }

        public static string GetStringFromConsole(string message = "\n Write a string: ")
        {
        l1:
            Console.Write(message);
            string str = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("\n>> Can not be empty, try again.. ");
                goto l1;
            }

            return str;
        }

        /// <summary>
        /// Clear current 1 Console line.
        /// </summary>
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            // Burada string verilmis char-dan, verilmis sayda birlesdirib,
            // yeni string yaradir.
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        /// <summary>
        /// Clear current Console line by count line.
        /// </summary>
        public static void ClearCurrentConsoleLineByCount(int count = 1)
        {
            if (count<=0)
            {
                throw new Exception("Line count can not be <= 0!");
            }

            int currentLineCursor = Console.CursorTop-count;
            Console.SetCursorPosition(0, Console.CursorTop-count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void Header(string str, char symbol = '-', ConsoleColor color = (ConsoleColor)(-1), ConsoleColor headeColor = (ConsoleColor)(-1))
        {
            Header(str, symbol, symbol, color, headeColor);
        }

        public static void Header(string str, char leftSymbol, char rightSymbol, ConsoleColor color)
        {
            Header(str, leftSymbol, rightSymbol, color, color);
        }

        public static void Header(string str, char leftSymbol, char rightSymbol, ConsoleColor color, ConsoleColor headerColor)
        {
            int widthWindow = Console.WindowWidth;
            int spaces = (widthWindow - str.Length - 2) / 2;

            Console.ForegroundColor = color;
            Console.Write($"{new string(leftSymbol, spaces)}");
            Console.ForegroundColor = headerColor;
            Console.Write($" {str} ");
            Console.ForegroundColor = color;
            Console.WriteLine($"{new string(rightSymbol, spaces)}\n");
            Console.ForegroundColor = (ConsoleColor)(-1);
        }
    }
}
