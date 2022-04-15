using System;
using System.Collections.Generic;
using Helper;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("test");


            Console.WriteLine(list.Remove("te"));

            Console.WriteLine();

            GenericStore<string> store = new GenericStore<string>();

            store.Add("test1");
            store.Add("test2");
            store.Add("test3");
            store.Add("test4");
            store.Add("test5");

            ConsoleHelper.Header("StringStore",'*', ConsoleColor.Magenta, ConsoleColor.Red);

            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            Console.WriteLine($"store.Count: {store.Count}\n");

            Console.WriteLine($"store[2]: {store[2]}\n");

            store.RemoveAt(2);

            Console.WriteLine("After:  store.RemoveAt(2)\n");

            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();


            store.RemoveAt(3);

            Console.WriteLine("After:  store.RemoveAt(3)\n");

            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();


            store.RemoveAt(0);

            Console.WriteLine("After:  store.RemoveAt(0)\n");

            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            Console.WriteLine($" After: store.Remove(\"test\") => {store.Remove("test")}\n");


            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            Console.WriteLine($" After: store.Remove(\"test4\") => {store.Remove("test4")}\n");


            foreach (var st in store.GetAll())
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            Person p = new Person() { Name = "Qabil", Surname = "Qurbanov" };
            Gender g = new Gender() { Name = "male" };

            DataTransform transform = new DataTransform();
            ConsoleHelper.Header("Generik Method", color:ConsoleColor.Cyan, headeColor:ConsoleColor.DarkBlue);

            // bu sekilde istenilen type-i argument kimi gondere bilerik.
            Console.WriteLine(transform.Reverse(p));
            Console.WriteLine(transform.Reverse(g));

            Console.WriteLine(transform.Reverse<Person>(p));

            // bele yazilarsa <type> verdiyimiz type uzre argument gondere bilerik ancaq:
            //Console.WriteLine(transform.Reverse<Gender>(p));

            Console.ReadKey();
        }
    }
}
