using System;
using System.Globalization;
using System.Text;
using System.Threading;
using Helper;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            AylarAzerbaycanDilinde();

            StringBuilderType();

            Console.ReadKey();

            // Only for Windows
            //AboutConsoleProperties();

        }

        private static void AylarAzerbaycanDilinde()
        {
            ConsoleHelper.SetDefaults();
            var months = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames;

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            Console.ReadLine();
        }

        private static void StringBuilderType()
        {
            StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < 1000; i++)
            //{
            //    //sb.Append(i);
            //    //sb.AppendLine(i.ToString());
            //    //sb.AppendFormat("{1}-{0}-{2}\n", i,6,"9");
            //    sb.AppendFormat("{0:d3} => {0:X3} => {0}\n", i);
            //}

            sb.Append("2022 il");

            Console.WriteLine(sb.ToString());

            sb.Insert(4, "-ci");

            Console.WriteLine(sb.ToString());
        }

        private static void GetPointerAddressIntAndString()
        {
            unsafe
            {
                int tr = 6;

                int* addrA = &tr;

                Console.WriteLine($"address a: {(long)addrA}");

                tr = 567;

                addrA = &tr;

                Console.WriteLine($"address a: {(long)addrA}");


                int b = 778;

                int* addrB = &b;

                Console.WriteLine($"address a: {(long)addrB}");

                b = 567;

                addrB = &b;

                Console.WriteLine($"address a: {(long)addrB}");


                string x = "";

                fixed (char* chX = x)
                {
                    Console.WriteLine($"str addr: {(long)chX}");
                }

                x += "c";

                fixed (char* chX = x)
                {
                    Console.WriteLine($"str addr: {(long)chX}");
                }

                x += "o";

                fixed (char* chX = x)
                {
                    Console.WriteLine($"str addr: {(long)chX}");
                }

            }
        }

        private static void SpeedProsess()
        {
            DateTime start = DateTime.Now;
            //proses
            DateTime stop = DateTime.Now;

            TimeSpan diff = stop - start;

            Console.WriteLine($"Ellapsed: {diff.Milliseconds}ms");
        }

        private static void Olcusunu3olculuSaxlma()
        {
            // default bosluqlarla
            for (int i = 0; i < 1000; i++)
            {
                string iStr = i.ToString().PadLeft(3);
                Console.WriteLine(iStr);
            }

            // bosluq yerine 0-la
            for (int i = 0; i < 1000; i++)
            {
                string iStr = i.ToString().PadLeft(3, '0');
                Console.WriteLine(iStr);
            }
        }

        private static void CreateCulture()
        {
            // Azerbbaycan medeniyyeti yaradildi
            CultureInfo ci = new CultureInfo("az-Latn-AZ");

            // Medeniyyetin butun Proqrama tedbiqi
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            string word = InputHelper.GetStringFromConsole();

            // Butun proqrama tedbiq etmeden medeniyyeti methoda oturmek(ci)
            Console.WriteLine(word.ToUpper(ci));

            Console.WriteLine(word.ToLower());
        }

        private static void WalkingCentence()
        {
            string centence = "next station Neriman Nerimanov ";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(centence);

                centence = centence.Substring(1) + centence[0];

                System.Threading.Thread.Sleep(500);
            }
        }

        private static void ByteCodeOfChar()
        {
            char c = 'h';
            Console.WriteLine(((byte)c));
        }

        private static void OneAndSymbol()
        {
            int test = 9;
            Console.WriteLine("test: " + test);
            Console.WriteLine("6 < 2 & int.TryParse(\"78\", out test): "
                + (6 < 2 & int.TryParse("78", out test)));
            Console.WriteLine("test: " + test);
        }

        private static void GetNumberWith9Digit()
        {
            l1:
            int num = InputHelper.GetIntFromConsole("9 reqemli eded daxil edin: ");

            if (num < 100000000 || num >= 1000000000)
            {
                Console.WriteLine($"{num} ededi 9 reqemli deyil!");
                goto l1;
            }
        }

        static bool IntTryParse(string str,out int value )
        {
            value = default;
            try
            {
                value = int.Parse(str);
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        static int GetNewNumFromNumOddDigits(int num)
        {
            int[] nums = new int[0];

            while (num > 0)
            {
                Array.Resize(ref nums, nums.Length + 1);
                nums[^1] = num % 10;
                num /= 10;
            }

            Array.Reverse(nums);

            int newNum = 0;

            for (int i = 0; i < nums.Length; i += 2)
            {
                newNum = newNum * 10 + nums[i];
            }

            return newNum;
        }

        private static void AboutConsoleProperties()
        {
            Random r = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int num = r.Next(0, 2);
                Console.Write(num);
            }

            Console.WindowTop = 0;
            Console.CursorTop = 10;
            Console.CursorLeft = 15;
            for (int i = 0; i < 16; i++)
            {
                Console.Write(" ");
            }
            Console.CursorLeft = 15;
            string word1 = " Salam ";
            string word2 = "Insanlar ";
            for (int i = 0; i < word1.Length; i++)
            {
                Console.Write(word1[i]);
                Thread.Sleep(200);
            }
            Thread.Sleep(1500);

            for (int i = 0; i < word2.Length; i++)
            {
                Console.Write(word2[i]);
                Thread.Sleep(200);
            }

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                Console.Write(")");
            }

        }
    }
}
