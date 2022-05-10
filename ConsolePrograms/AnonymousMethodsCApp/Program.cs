using System;

namespace AnonymousMethodsCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MethodWithName() ->");
            // adli method
            MethodWithName();

            // MethodWithName adli methodu action delegate-sine referanslamisiq, add elemisik
            Action action = MethodWithName;


            Console.WriteLine("action() ->");
            action();

            Console.WriteLine("action.Invoke() ->");
            action.Invoke();

            Action withAnonymousMethod = delegate
            {
                // anonymous method
                Console.WriteLine("Called anonymous method!\n");
            };

            Console.WriteLine("withAnonymousMethod() ->");
            withAnonymousMethod();


            Console.WriteLine("RunSafe(delegate{ ... }) ->");
            // eyni codu tekrar yaziriqsa, bu methodu anonym yox adli method kimi istifade etmeliyik
            // anonym methodlari 1 defe istifade edilecekse yazilir.
            RunSafe(delegate
            {
                Console.WriteLine("Called anonymous method!\n");
            });

            // Anonymous method with parametr:
            Action<string> anonymousMethodWithParametr = delegate (string str)
            {
                Console.WriteLine($"Called Anonymous method with parametr, value is: {str}!\n");
            };

            Console.WriteLine("Action<string> anonymousMethodWithParametr = delegate(string str){ ... } -> \n" +
                "anonymousMethodWithParametr(\"AnonymousMethodValue\") -> ");
            anonymousMethodWithParametr("AnonymousMethodValue");

            // Lambda method:
            Console.WriteLine("RunSafe(() => { ... })->");
            RunSafe(() =>
            {
                Console.WriteLine("Called Lambda method!\n");
            });

            // Lambda method with parametr:
            Action<int> lambdaMethodWithParametr = (int x) =>
            {
                Console.WriteLine($"Called Lambda method with parametr, value is: {x}!\n");
            };

            Console.WriteLine("Action<int> lambdaMethodWithParametr = (int x) => { ... } -> \n" +
                "ambdaMethodWithParametr(12) ->");
            lambdaMethodWithParametr(12);

            Console.ReadKey();
        }
        // Callback methods:
        // Method parametr kimi gonderilir ve body-de istifade edilir:
        private static void RunSafe(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void MethodWithName()
        {
            Console.WriteLine("Called method with name!\n");
        }
    }
}
