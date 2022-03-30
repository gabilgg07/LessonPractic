using System;
using System.Diagnostics;
using Helper;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.SetDefaults();

            Console.ReadKey();
        }

        private static void Task3()
        {
            // 1-den 1000-e kimi ixtiyari(random) bir eded secilir.
            // Istifadeciden bu ededi tapmasini isteyirik.
            // Her defesinde istifdeci ededi tapanadek
            // novbeti daxil edeceyi ededin indi daxil etdiyinden 
            // boyuk ve ya kicik olmasini deyirik.

            int counter = 1;
            Random random = new Random();

            Stopwatch sw = new Stopwatch();

            int randomNum = random.Next(1, 1000);
            sw.Start();
        lblBetween:
            Console.WriteLine(" 1 və 1000 ədədləri arasından ixtiyari bir ədəd seçildi.");
            Console.Write(" Bu ədədi tapmaq üçün, ");
        lblGetNumAgain:
            int num = ConsoleHelper.GetIntNumFromConsole(" ədəd daxil edin: ", "tam ədəd deyil, yenidən cəhd edin.. ");
            if (num < 1 || num > 999)
            {
                Console.WriteLine(" seçdiyiniz ədəd verilmiş aralıqda deyil, yenidən cəhd edin.. ");
                counter++;
                goto lblBetween;
            }
            else if (num < randomNum)
            {
                Console.Write(" Böyük ");
                counter++;
                goto lblGetNumAgain;
            }
            else if (num > randomNum)
            {
                Console.Write(" Kiçik ");
                counter++;
                goto lblGetNumAgain;
            }
            else
            {
                sw.Stop();
                Console.WriteLine($"{counter}{DataHelper.ForSuffixOfNumberForAZ(counter)} cəhddə {sw.ElapsedMilliseconds / 1000} saniyəyə {randomNum} ədədini tapdınız.");
            }

        }

        private static void EdedSadedirmi()
        {
            int num = 213;

            int counter = 2;

            bool result = false;
            Console.WriteLine(Math.Pow(num, 0.5)); // num ustu 1/2 (2-de 1)
            Console.WriteLine(Math.Sqrt(num)); // kvadrat kokalti

            while (Math.Pow(num, 0.5) > counter)
            {
                if (num % counter == 0)
                {
                    Console.WriteLine(counter);
                    result = true;
                    break;
                }

                counter++;
            }

            if (result)
            {
                Console.WriteLine("Sade deyil!");
            }
            else
                Console.WriteLine("Sadedir");
        }

        private static void Task2()
        {
            // 8) 1-1000 qeder ededlerin icerisinden,
            // daxilinde 3 reqemi olmayib,
            // reqemleri cemi 3 olan en sonuncu eded hansidir?

            for (int i = 1000; i > 0; i--)
            {
                if (i % 10 > 2 || (i / 10) % 10 > 2 || i / 100 > 2)
                {
                    continue;
                }

                int sum = i % 10 + (i / 10) % 10 + i / 100;

                if (sum == 3)
                {
                    Console.WriteLine($"Axtardiginiz eded: {i}");
                    break;
                }

            }
        }

        private static void Task1()
        {
            // 1-1000 qeder ededlerin icerisinden ele ededleri cap et ki,
            // hem reqemlerinin cemi 5-e bolunsun,
            // hem de ozu 5-e bolunsun.

            int count = 0;
            int counter = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 5 != 0)
                {
                    continue;
                }
                count++;
                if (MathHelper.SumNumDigits(i) % 5 == 0)
                {
                    counter++;
                    Console.WriteLine($">> {i} ededinin hem ozu, hem de reqemlerinin cemi 5-e bolunur.");
                }

            }

            Console.WriteLine($"\n>> Ozu 5-e bolunenlerin sayi: {count}\n" +
                $">> Hem ozu, hem de reqemlerinin cemi 5-e bolunenlerin sayi: {counter}");
        }
    }
}
