using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskStore taskStore = new TaskStore();
            taskStore.MaxCount = 2;

            // imkan veririk ki, OnOverFlow eventi bas verdikde,
            // OnStoreOverFlow methodu islet.
            taskStore.OnOverFlow += OnStoreOverFlow;

            taskStore.Add("Test1");
            taskStore.Add("Test2");
            taskStore.Add("Test3");

            // IEnumerator sayesinde foreach-de taskStore-ni yaza bilirik
            foreach (var item in taskStore)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void OnStoreOverFlow(string msg)
        {
            // istese istifade eder msg istese yox. oz secimidir.
            Console.WriteLine("\nArtiq doludur!\n");
            Console.WriteLine($"Bu da eventle oturulen mesage: {msg}\n");
        }
    }
}
