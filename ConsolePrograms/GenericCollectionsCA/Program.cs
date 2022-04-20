using System;
using System.Collections.Generic;
using Helper;

namespace GenericCollectionsCA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection:

            //       T
            // List<type> - ArrayList-in generic formasi.

            #region List<int>

            List<int> intList = new List<int>();

            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.Header("List<int> Learning Start", '=');
            Console.ForegroundColor = (ConsoleColor)(-1);

            // Add verilen type-dan olanlari ancaq mumkundur.
            intList.Add(44);
            intList.Add(7);
            intList.Add(3);
            intList.Add(75);
            intList.Add(7);
            intList.Add(321);

            Console.WriteLine("----- intList ----\n");

            //foreach (var num in intList)
            //{
            //    Console.Write(num + (intList.FindLast(x => true) != num ? ", " : ""));
            //}
            // => sadesi))
            Console.WriteLine(string.Join(", ", intList));


            // .Remove(value) -> verilen deyere uygun ilk tapdigini silir.
            intList.Remove(7);


            Console.WriteLine("\n----- intList.Remove(value first -> 7) ----\n");

            Console.WriteLine(string.Join(", ", intList));

            // .RemoveAt(index) -> verilen indeksdekini silir.
            intList.RemoveAt(2);


            Console.WriteLine("\n----- intList.RemoveAt(index -> 2) ----\n");

            Console.WriteLine(string.Join(", ", intList));

            // .RemoveRange(begin index, count) -> verilmis indeksden baslayaraq,
            // verilmis say qeder silir.
            intList.RemoveRange(0, 2);


            Console.WriteLine("\n----- intList.RemoveRange(begin index, count -> 0,2) ----\n");

            Console.WriteLine(string.Join(", ", intList));

            // .RemoveAll(predicate) -> verilen sert(predicate)-e
            // true cavabi qaytaranlarin hamisini silir.
            intList.RemoveAll(x => x > 9);


            Console.WriteLine("\n----- intList.RemoveAll(predicate -> x => x > 9) ----\n");

            Console.WriteLine(string.Join(", ", intList));

            intList.RemoveAll(x => true); // bele bir basa true verersek hamisini silecek.


            Console.WriteLine("\n----- intList.RemoveAll(x => true) ----\n");

            Console.WriteLine(string.Join(", ", intList));

            intList.Add(44);
            intList.Add(777);
            intList.Add(35);
            intList.Add(75);
            intList.Add(2);
            intList.Add(321);

            Console.WriteLine("\n----- intList add again ----\n");

            Console.WriteLine(string.Join(", ", intList));

            // .Clear() elave sert yoxlanmada bir basa hamisini silir.
            intList.Clear();

            Console.WriteLine("\n----- intList.Clear() ----\n");

            Console.WriteLine(string.Join(", ", intList));

            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Header("List<int> Learning End", '_');
            Console.ForegroundColor = (ConsoleColor)(-1);

            #endregion


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
            Console.ForegroundColor = (ConsoleColor)(-1);


            #region List<string>

            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.Header("List<string> Learning Start", '=');
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

            //foreach (var str in strList)
            //{
            //    Console.Write(str + (strList.FindLast(x => true) != str ? ", " : ""));
            //}

            Console.WriteLine(string.Join(", ", strList));

            strList.RemoveAll(s => s.Length <= 6);

            Console.WriteLine("\n---- strList.RemoveAll(s=>s.Length<=6) ----\n");

            Console.WriteLine(string.Join(", ", strList));

            strList.RemoveAll(s => s[0] == 'M');

            Console.WriteLine("\n---- strList.RemoveAll(s=>s[0]=='m') ----\n");

            Console.WriteLine(string.Join(", ", strList));

            strList.RemoveAll(s => s.StartsWith("Hes"));

            Console.WriteLine("\n---- strList.RemoveAll(s=>s.StartsWith(\"Hes\")) ----\n");

            Console.WriteLine(string.Join(", ", strList));

            strList.RemoveAll(s => s.EndsWith("zade"));

            Console.WriteLine("\n---- strList.RemoveAll(s=>s.EndsWith(\"zade\")) ----\n");

            Console.WriteLine(string.Join(", ", strList));

            strList.RemoveAll(s => s.Contains("bb"));

            Console.WriteLine("\n---- strList.RemoveAll(s=>s.Contains(\"bb\")) ----\n");

            Console.WriteLine(string.Join(", ", strList));

            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Header("List<string> Learning End", '_');
            Console.ForegroundColor = (ConsoleColor)(-1);

            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
            Console.ForegroundColor = (ConsoleColor)(-1);

            // Dictionary<TKey,TValue> - HashTable-in generic formasai.

            #region Dictionary

            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.Header("Dictionary<TKey,TValue> Learning Start", '=');
            Console.ForegroundColor = (ConsoleColor)(-1);

            // Dictionary KeyValuePairs type-larindan ibaret bir collection type-dir.
            // KeyValuePair tek <Key, Value> type-dir. List deyil.
            //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            // var ile seliqeli gorunur:
            var strIntDic = new Dictionary<string, int>();

            strIntDic.Add("iki", 2);
            strIntDic.Add("otuz", 30);
            strIntDic.Add("on iki", 12);
            strIntDic.Add("yuz", 100);
            strIntDic.Add("elli uc", 53 );

            Console.WriteLine("---- strIntDic ----\n");

            Console.WriteLine("key\t\tvalue\n");


            // Generic Key-Value Pair type-larda foreach-de
            // key value propertilerin verir item-e.
            // Non-generiklerde object kimi qaytarir.
            foreach (var item in strIntDic)
            {
                Console.WriteLine($"{item.Key}:{(item.Key.Length<7?"\t":"")}\t {item.Value}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Header("Dictionary<TKey,TValue> Learning End", '_');
            Console.ForegroundColor = (ConsoleColor)(-1);

            #endregion


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
            Console.ForegroundColor = (ConsoleColor)(-1);

            // SortedList<TKey,TValue> - SortedList-in generic formasai.

            #region SortedList generic type

            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.Header("SortedList<TKey,TValue> Learning Start", '=');
            Console.ForegroundColor = (ConsoleColor)(-1);

            //SortedList<string, int> keyValuePairs = new Dictionary<string, int>();

            // var ile seliqeli gorunur:
            var intStrSorted = new SortedList<int, string>();

            intStrSorted.Add(2,"iki");
            intStrSorted.Add(30, "otuz");
            intStrSorted.Add(12, "on iki");
            intStrSorted.Add(100, "yuz");
            intStrSorted.Add(53, "elli uc");

            // key-i int yeni number type oldugundan, kemiyyete gore siralayir.

            Console.WriteLine("---- intStrSorted ----\n");

            Console.WriteLine("key\tvalue\n");
            foreach (var item in intStrSorted)
            {
                Console.WriteLine($"{item.Key} :\t {item.Value}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Header("SortedList<TKey,TValue> Learning End", '_');
            Console.ForegroundColor = (ConsoleColor)(-1);

            #endregion


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
            Console.ForegroundColor = (ConsoleColor)(-1);

            #region List Attachment

            Console.WriteLine("---- List<KeyValuePair<string, int>> ----\n");

            List<KeyValuePair<string, int>> ll = new List<KeyValuePair<string, int>>();

            ll.Add(new KeyValuePair<string, int>("bir", 1));

            // KeyValuePair tipindedi listin 0 -ci item-i.
            // Amma esas bunun evezine Dictionary-den istifade edilir.
            Console.WriteLine($"{ll[0].Key} {ll[0].Value}");

            Console.WriteLine();

            Console.WriteLine("---- List<Person> ----\n");

            Person p = new Person("Kamil", "Ehmedov");

            var people = new List<Person>();

            people.Add(p);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }

            Console.WriteLine();

            List<int> wOClear = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Collectionlarda her defe element eleve edib silende
            // collectionun uzunlugu(count-u) yeni qiymet alir.


            //int countOfList = wOClear.Count;
            //for (int i = 0; i < countOfList; i++)
            //{
            //    wOClear.RemoveAt(0);
            //}
            // ve ya bele 
            while (wOClear.Count>0)
            {
                wOClear.RemoveAt(0);
            }

            Console.WriteLine("---- List<int> wOClear Clear With RemoveAt ----");

            foreach (var item in wOClear)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
            Console.ForegroundColor = (ConsoleColor)(-1);

            #region Stack Queue HashSet

            Console.WriteLine("---- Stack<T> & Queue<T> Generic ----\n");

            Stack<int> torba = new Stack<int>();
            torba.Push(8);
            torba.Push(76);
            Console.WriteLine("---- Stack<int> torba ----\n");

            //foreach (var item in torba)
            //{
            //    Console.Write(item + ", ");
            //}

            Console.WriteLine(string.Join(", ", torba));

            int peek = torba.Peek(); // bize novbede olan item-i gosterir.
            Console.WriteLine($"\nOn next peek: {peek}\n");


            int pop = torba.Pop(); // bize cixarilan item-i qaytarir.
            Console.WriteLine($"Removed: {pop}\n");
            Console.WriteLine($"torba.Pop(): {torba.Pop()}\n");
            bool res = torba.TryPop(out int resNum);// ?

            Console.WriteLine($"torba.TryPop: {res} - int: {resNum}\n");


            Queue<string> boru = new Queue<string>();

            boru.Enqueue("1-ci");
            boru.Enqueue("2-ci");

            Console.WriteLine("---- Queue<string> boru ----\n");

            //foreach (var item in boru)
            //{
            //    Console.Write(item + ", ");
            //}

            Console.WriteLine(string.Join(", ", boru));

            Console.WriteLine($"\nboru.Dequeue(): {boru.Dequeue()}\n"); // cixarilan item-i qaytarir
            Console.WriteLine($"boru.Peek(): {boru.Peek()}\n"); // novbede olani


            Console.WriteLine("---- HashSet<T> Generic ----\n");

            HashSet<int> hash = new HashSet<int>();

            hash.Add(2);
            hash.Add(4);
            hash.Add(2);
            hash.Add(4);
            hash.Add(3);
            hash.Add(3);

            // Eyni olan elementleri tekrar yuklemir,
            // errar da vermir, neytral qalir.

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Person p1 = new Person("a1", "s1");
            Person p2 = new Person("a2", "s2");
            Person p3 = new Person("a3", "s3");
            Person p4 = new Person("a4", "s4");
            Person p5 = new Person("a5", "s5");
            Person p6 = new Person("a6", "s6");

            HashSet<Person> hashP = new HashSet<Person>();

            hashP.Add(p1);
            hashP.Add(p4);
            hashP.Add(p1);
            hashP.Add(p5);
            hashP.Add(p4);
            hashP.Add(p3);

            foreach (var item in hashP)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }

            #endregion

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
