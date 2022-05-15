using System;

namespace LoopLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            int[] arr = { 100, 15, 20 };

            int[] arr2 = arr;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");


            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=====================");

            Array.Resize(ref arr, 4);

            arr[3] = 76;


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");


            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i + 1 == arr.Length)
            //    {
            //        Console.WriteLine($"{arr[i]}");
            //        continue;
            //    }
            //    arr[i + 1] = arr[i] + 10;
            //    Console.WriteLine($"{arr[i]}");
            //}

            //int temp = 0;

            //SortArray(arr, temp);

            //SortReverseArray(arr, temp);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------");


        }

        private static void SortReverseArray(int[] arr, int temp)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])  
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private static void SortArray(int[] arr, int temp)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
        }
    }
}   
