using System;
using Helper;

namespace ExtensionMethods
{

    // Extension - artirma, elave demekdir.

    // Her type ucun oz extension-mizi yaza bilerik.

    // Extension hemin yazildigi
    // type-in obyektinde ortaya cixir.

    // Micrasoft-un secdiyi methodlardan elave.


    // Extension method yazmaq isteyirikse,
    // yazacagimiz class da, method da static olmalidir
    // ve methodun 1-ci parametrinin (extension yazacagimiz type-in)
    // qarsisina this keyword-u yazilir.


    static class ExtentionsClass
    {

        // Static class-in icindeki ,
        // static method-un icindeki ilk parametr olan
        // type-in qarsisina this yazdigimizda,
        // bu method hemin type-in EXTENSION-u olur.
        public static int YearsIfDiffFromNow(this TimeSpan ts) // TimeSpan type-ina
                                                               // extension-umuzu yazdiq.
                                                               // Adlandirilma type gore olur:
                                                               // TimeSpan extension.
                                                               // Butun TimeSpan-lar ucun
                                                               // bu methodu cagira bilerik.
        {
            DateTime date = DateTime.Now - ts;

            int years = DateTime.Now.Year - date.Year;

            if (DateTime.Now.Month > date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day >= date.Day))
            {
                return years;
            }
            else
            {
                return years - 1;
            }
        }

        static public string ReverseString(this string value, string splitter = "") // string type-ina 
                                                                                    // extension-umuzu yazdiq.
                                                                                    // String extension..

                                                                                    // Butun string-ler ucun
                                                                                    // bu methodu cagira bilerik.
        {
            char[] arr = value.ToCharArray();

            Array.Reverse(arr);

            value = string.Join(splitter, arr);

            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Bu (extension) method hem yazildigi
            // class uzerinden cagrila bilinir.
            Console.WriteLine(ExtentionsClass.ReverseString("test"));


            // Hem de hemin type-in obyekti(instance-i)
            // uzerinden cagrila bilinir
            Console.WriteLine("test2".ReverseString());


            // Bir nece parametr olarsa
            // class uzerinden parametrler adi qaydada
            // methodun moterezeleri icinden oturulur.
            Console.WriteLine(ExtentionsClass.ReverseString("test", "-"));

            // Type uzerinden olarsa this olan sayilmir,
            // cunki type-in ozudur.
            // Moterize icinde diger parametrler oturulur.
            Console.WriteLine("test2".ReverseString("_"));

            Console.ReadKey();

            TimeSpan diff = DateTime.Now - new DateTime(1991, 3, 7);
            int year = diff.YearsIfDiffFromNow();

            Console.WriteLine(year);

            Console.ReadKey();

        }
    }


    
}
