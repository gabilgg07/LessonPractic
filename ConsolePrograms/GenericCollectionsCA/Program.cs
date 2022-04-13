using System;
using System.Collections.Generic;

namespace GenericCollectionsCA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection:
            // List<type> - ArrayList-in generic formasi.

            #region List<int>

            List<int> intList = new List<int>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==== List<int> Learning Start ====\n");
            Console.ForegroundColor = (ConsoleColor)(-1);

            // Add verilen type-dan olanlari ancaq mumkundur.
            intList.Add(44);
            intList.Add(7);
            intList.Add(3);
            intList.Add(75);
            intList.Add(7);
            intList.Add(321);

            Console.WriteLine("----- intList ----\n");

            foreach (var num in intList)
            {
                Console.Write(num + (intList.FindLast(x => true) != num ? ", " : ""));
            }


            // .Remove(value) -> verilen deyere uygun ilk tapdigini silir.
            intList.Remove(7);


            Console.WriteLine("\n\n----- intList.Remove(value first -> 7) ----\n");

            foreach (var num in intList)
            {
                Console.Write(num + (intList.FindLast(x => true) != num ? ", " : ""));
            }


            // .RemoveAt(index) -> verilen indeksdekini silir.
            intList.RemoveAt(2);


            Console.WriteLine("\n\n----- intList.RemoveAt(index -> 2) ----\n");

            foreach (var num in intList)
            {
                Console.Write(num + (intList.FindLast(x => true) != num ? ", " : ""));
            }

            // .RemoveRange(begin index, count) -> verilmis indeksden baslayaraq,
            // verilmis say qeder silir.
            intList.RemoveRange(0, 2);


            Console.WriteLine("\n\n----- intList.RemoveRange(begin index, count -> 0,2) ----\n");

            foreach (var num in intList)
            {
                Console.Write(num +  (intList.FindLast(x => true) != num ? ", " : ""));
            }


            // .RemoveAll(predicate) -> verilen sert(predicate)-e
            // true cavabi qaytaranlarin hamisini silir.
            intList.RemoveAll(x => x > 9);


            Console.WriteLine("\n\n----- intList.RemoveAll(predicate -> x => x > 9) ----\n");

            foreach (var num in intList)
            {
                Console.Write(num +  (intList.FindLast(x => true) != num ? ", " : ""));
            }

            intList.RemoveAll(x => true); // bele bir basa true verersek hamisini silecek.


            Console.WriteLine("\n\n----- intList.RemoveAll(x => true) ----\n");

            foreach (var num in intList)
            {
                Console.Write(num +  (intList.FindLast(x => true) != num ? ", " : ""));
            }

            intList.Add(44);
            intList.Add(777);
            intList.Add(35);
            intList.Add(75);
            intList.Add(2);
            intList.Add(321);

            Console.WriteLine("\n\n----- intList add again ----\n");

            foreach (var num in intList)
            {
                Console.Write(num +  (intList.FindLast(x => true) != num ? ", " : ""));
            }

            // .Clear() elave sert yoxlanmada bir basa hamisini silir.
            intList.Clear();

            Console.WriteLine("\n\n----- intList.Clear() ----\n");

            foreach (var num in intList)
            {
                Console.Write(num +  (intList.FindLast(x => true) != num ? ", " : ""));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n==== List<int> Learning End ====\n");
            Console.ForegroundColor = (ConsoleColor)(-1);

            #endregion


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==== List<string> Learning Start ====\n");
            Console.ForegroundColor = (ConsoleColor)(-1);

            List<string> strList = new List<string>();

            strList.Add("Adilov");
            strList.Add("Melikzade");
            strList.Add("Qurbanov");
            strList.Add("Adilov");
            strList.Add("Abbaszade");
            strList.Add("Abbasov");
            strList.Add("Abbasova");
            strList.Add("Hesenov");
            strList.Add("Eliyev");

            Console.WriteLine("---- strList ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            }

            strList.RemoveAll(s => s.Length <= 6);

            Console.WriteLine("\n\n---- strList.RemoveAll(s=>s.Length<=6) ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x=>true)!=str?", ":""));
            }

            strList.RemoveAll(s => s[0] == 'M');

            Console.WriteLine("\n\n---- strList.RemoveAll(s=>s[0]=='m') ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            }

            strList.RemoveAll(s => s.StartsWith("Hes"));

            Console.WriteLine("\n\n---- strList.RemoveAll(s=>s.StartsWith(\"Hes\")) ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            }

            strList.RemoveAll(s => s.EndsWith("zade"));

            Console.WriteLine("\n\n---- strList.RemoveAll(s=>s.EndsWith(\"zade\")) ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            }

            strList.RemoveAll(s => s.Contains("bb"));

            Console.WriteLine("\n\n---- strList.RemoveAll(s=>s.Contains(\"bb\")) ----\n");

            foreach (var str in strList)
            {
                Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n==== List<string> Learning End ====\n");
            Console.ForegroundColor = (ConsoleColor)(-1);

            Console.ReadKey();
        }
    }
}
