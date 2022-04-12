using System;

namespace RemoveFromArrayCA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;

            Console.WriteLine("---- arr ----");
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }

            int removedIndex = 3;


            for (int i = removedIndex-1; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("---- changed arr ----");
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }

            int[] newArr = new int[arr.Length - 1];

            Array.Copy(arr, newArr, newArr.Length);

            Console.WriteLine("---- new arr ----");

            foreach (var num in newArr)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("==== end ====");

            Console.ReadKey();
        }
    }
}
