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

            Console.WriteLine(list);

            StringStore store = new StringStore();

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

            Console.ReadKey();
        }
    }
}
