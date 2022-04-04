using System;
using Helper;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleHelper.SetDefaults();

            // Bize bir qutu lazim olur ki, onunla her sey dasina bilsin
            // ve muveqqeti olaraq bir yere kimi datamizi dasiyaq.

            // Object butun datalrin, classlarin ve s ana class-i oldugundan
            // onunla dasimaq mumkundur.

            // Object icine her hansi bir data
            // novunden data qoyulmasina - boxing deyilir.

            object integerType = 6;
            object strType = "test";
            object dateType = DateTime.Now;

            // Object data-ni type olaraq yaddasinda saxlayir,
            // amma detecte ede bilmirik. Buna gore de,
            // eksine olaraq object qutusundan data-ni
            // oz type-ina (qutusuna) qoymaga ise - unboxing deyilir.
            // casting ile:

            // tehlukeli castingler:
            int num = (int)integerType;

            Console.WriteLine(num);

            DateTime date = Convert.ToDateTime(dateType);

            Console.WriteLine(date);

            // tehlukesiz castingler:

            int? numNullable = integerType as int?;

            if (numNullable != null)
            {
                Console.WriteLine($"numNullable: >>{numNullable}<< - null deyil.");
            }

            string str = strType as string;

            if (str == null)
            {
                Console.WriteLine(" String type-dan Null qayitdi");
            }
            else
            {
                Console.WriteLine($">>{str}<< - string-e duzgun cast olundu.");
            }

            // en sade ve yeni usul:

            //if (strType is not string str)
            //{
            //    Console.WriteLine(" String type-dan Null qayitdi");
            //}
            //else
            //{
            //    Console.WriteLine($">>{str}<< - string-e duzgun cast olundu.");
            //}

            if (dateType is DateTime dateTime)
            {
                Console.WriteLine($">>{dateTime.ToString("dd-MMM-yyyy")}<< tarixi qutudan cixarildi.");
            }

            // Boxin ve unboxing prosessoru yoran ve bahali emeliyyatlardandir.

            // Double ve int arasindaki boxin, unboxing deyil
            // implicit ve explisit conversion-di.

            double d=9;
            int i=2;

            d = i;
            i = (int)d;

            Console.WriteLine(i);

            // Object uzerindeki proses boxin, unboxing adlanir:

            // any type -> object => boxing
            // object -> any type => unboxing

            Console.ReadKey();
        }
    }
}
