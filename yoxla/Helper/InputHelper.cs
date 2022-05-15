using System;

namespace Helper
{
    public static class InputHelper
    {
#nullable enable
        public static string GetStringFromConsole(string inputMsg = "Text daxil edin: ", string? outputMsg = "Daxil etdiyiniz bosluq ola bilmez!\n==============================")
        {
            l1:
            Console.Write(inputMsg);
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
            {
                if (outputMsg != null)
                {
                    Console.WriteLine(outputMsg);
                }
                goto l1;
            }

            return value;
        }

        public static int GetIntFromConsole(string inputMsg = "Eded daxil edin: ", string outputMsg = "Daxil etdiyiniz eded deyil!\n==============================")
        {
            l1:
            Console.Write(inputMsg);
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                if (outputMsg != null)
                {
                    Console.WriteLine(outputMsg);
                }
                goto l1;
            }

            return value;
        }

        public static double GetDoubleFromConsole(string inputMsg = "Rasional eded daxil edin: ", string? outputMsg = "Daxil etdiyiniz eded deyil!\n==============================")
        {
            l1:
            Console.Write(inputMsg);
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                if (outputMsg != null)
                {
                    Console.WriteLine(outputMsg);
                }
                goto l1;
            }

            return value;
        }
#nullable disable
    }
}
