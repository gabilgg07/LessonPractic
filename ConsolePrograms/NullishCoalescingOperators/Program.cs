using System;

namespace NullishCoalescingOperators
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
