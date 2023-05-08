using System;
using System.Globalization;
using System.Text;

namespace yoxla
{
    class Program
    {
        static void Main(string[] args)
        {

            string dateUiFormat = CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern;

            bool hasMM = dateUiFormat.Contains("MM");
            bool hasDD = dateUiFormat.Contains("dd");
            bool hasYY = dateUiFormat.Contains("yy");

            string dateFormat = dateUiFormat
                .Replace("MMM", "ay")
                .Replace(hasMM ? "MM" : "M", "ay")
                .Replace(hasDD ? "dd" : "d", "gun")
                .Replace(hasYY ? "yy" : "yyyy", "il");

            Console.Write($"Bir tarix daxil edin ({dateFormat} - formatinda): ");
            string strDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(strDate);

            Console.WriteLine("---------------");
            Console.WriteLine(date);

        }

        private static void CurrentDataTime()
        {
            int hoursNow = -(DateTime.UtcNow - DateTime.Now).Hours;
            string message = (hoursNow > 0 ? "+" + hoursNow : hoursNow.ToString());


            Console.WriteLine(message);
        }

        private static void NumbersCascating()
        {
            //byte b1 = 76;
            //int i = b1;

            //checked
            //{
            //    int a = 423;
            //    byte b = (byte)a;

            //    Console.WriteLine(b);
            //}

            checked
            {
                double d = 4.6;
                int i = (int)d;

                Console.WriteLine(i);
            }
        }

        private static void ChangeEncodingConsole()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Azərbaycanca yazılış.");

            string cumle = Console.ReadLine();

            Console.WriteLine("-------------------");
            Console.WriteLine(cumle);
        }

        private static void TypeControl()
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();

            Console.WriteLine("World!");

            var a = 6;

            Console.WriteLine(a.GetTypeCode());

            byte b = 4;
            decimal x = 6.8m;

            Console.WriteLine(b.GetType().Name);

            Console.WriteLine(Console.ReadLine() + " - " + x);

        }
    }
}
