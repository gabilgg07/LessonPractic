using System;

namespace NullishCoalescingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // >> Value type-laari nullable type
            // ede bilmek ucun qarsisina ? isaresi qoyulur.
            int? a = null;

            // Nullable type hansiki struct type-dan duzeldilib,
            // onlarda built-in olaraq .ToString() methodunda
            // null gelerse null qaytar xususiyyeti yazilib.
            // Ona gore error vermir.
            Console.WriteLine(a.ToString());
            Console.WriteLine((a as object)?.ToString()); // object(referance) type-a cast
                                                          // edende bu xususiyyet itir.

            // Nullble type-larin .HasValue parametri var.
            // Icinde deyer varsa true qaytarir,
            // null-dursa false qaytarir:
            if (a.HasValue)
            {
                Console.WriteLine($"if -> a.HasValue: {a.HasValue}");
            }
            else
            {
                Console.WriteLine($"else -> a.HasValue: {a.HasValue}");
            }

            //-----------------------------------------------------------

            // String ozunu value type kimi aparmasi:

            int num = 5;

            Console.WriteLine(num); // output: 5
            PrintInt(num); // output: 11
            Console.WriteLine(num); // output: 5

            string str = "Code";

            Console.WriteLine(str); // output: Code
            PrintString(str); // output: Code Acaademy
            Console.WriteLine(str); // output: Code

            Console.ReadKey();
        }

        private static void PrintInt(int num)
        {
            num += 6;
            Console.WriteLine($"In Method: {num}");
        }

        private static void PrintString(String str)
        {
            str += " Academi";
            Console.WriteLine("InMethod: "+str);
        }

        private static void ClassesNullChaked()
        {
            Person p = null;

            // >> BButun null olma ehtimali olan
            // type-larin (default-u null olan)
            //  qarsisina ?(sual) isaresi qoyuruq:
            Console.WriteLine(p?.Age.ToString());
            Console.WriteLine(p?.Name.ToString()); // p null oldugundan ? onu stoplayir,
                                                   // p-de dayanir.Ne Name-e,
                                                   // ne de ToString() methoduna kecmir hec.
                                                   // Umumi null qaytarir.

            Console.WriteLine((p?.Name)?.ToString()); // bu sekilde ise ? isaresi p-de stopluyur.
                                                      // Name-e kecmir. Moterize icinde
                                                      // emeliyyat icra olunub, null qayidir.
                                                      // Sonra moterezenin neticesi ile ishe davam etdiyinden
                                                      // null-a .ToString()-i ceht edir, bununla da
                                                      // error qaytarir.
                                                      // Ona gore de moterizeden
                                                      // sonra da ? isaresi qoyulmalidir. 

            p = new Person();

            Console.WriteLine(p?.Age.ToString());
            Console.WriteLine(p?.Name?.ToString()); // p null deyil, ona gore Name-e kecir.
                                                    // Name null-du, ona gore ? isaresi onu stopluyur
                                                    // ve .ToStringe() methoduna kecmir.

            Console.WriteLine(p?.Gender?.Name?.ToString());

        }

        private static void AnonymousObjectNullable()
        {
            int counter = 0;
            // >> Obyekte string menimseden de ->
            object o = "test";

            // -> .ToString() methodu var.
            string str = o.ToString();

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< String");

            // >> Number de menimseden de ->
            o = 5;

            // -> .ToString() methodu var
            str = o.ToString();

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< Number");

            // >> Null-a beraber olarsa amma ->
            o = null;

            // -> null-in .toString() methodu
            // yoxdur deye exeption(error) cixardir.

            //str = o.ToString();

            // >> Buna gore ? isaresinden istifade edirik ki,
            // bu obyekt(referance type) null da ola biler,
            // null olmazsa .ToString() methodunu islet:

            str = o?.ToString();

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< '?' -> Null-conditional operator");

            // >> ?? isaresinde ise,

            str = (o ?? "bosdur").ToString();

            // >> object null-dursa "bosdur" stringini gotur,
            // bos deyilse icinde olani

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< '??' -> Null-coalescing operator");

            // >> ((Primary,Secondary => yadda qalmasi ucun))
            // Ternary conditional operators ?: istifade ederek:

            str = o == null ? "bosdur" : o.ToString();


            counter++;
            Console.WriteLine($"{counter}. >>{str}<< '? :' -> Ternary conditional operator");

            dynamic d = new
            {
                Name = "Ad",
                Surname = "Surname"
            };

            str = d.Name.ToString();


            counter++;
            Console.WriteLine($"{counter}. >>{str}<< dynamic object d.Name");

            d = null;

            str = d?.Name.ToString();

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< dynamic object d=null olanda d?.Name.ToString()");

            d = new
            {
                Name = (string)null, // dynamiv type oldugundan
                                     // null-un hansi type-in null-u oldugunu bildirmeliyik,
                                     // yoxsa compile error verir.
                Surname = "Surname"
            };

            str = d?.Name?.ToString();

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< dynamic object d.Name=null olanda d?.Name?.ToString()");

            d = new
            {
                Name = "Ad",
                Surname = "Surname"
            };

            str = d?.Name?.ToString();
            // OR
            str = (d?.Name as string)?.ToString(); // dynamic oldugu ucun ToString methodunu gormur
                                                   // ona gore de as string - den istifade edirik.

            counter++;
            Console.WriteLine($"{counter}. >>{str}<< dynamic object d.Name='Ad' olanda d?.Name?.ToString()");
        }
    }

    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }

    class Gender
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
