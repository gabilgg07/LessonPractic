using System;

namespace AnonymousMethodsCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MethodWithName() =>");
            // adli method
            MethodWithName();

            // MethodWithName adli methodu action delegate-sine referanslamisiq, add elemisik
            Action action = MethodWithName;


            Console.WriteLine("action() =>");
            action();

            Console.WriteLine("action.Invoke() =>");
            action.Invoke();

            Action withAnonymousMethod = delegate
            {
                // anonymous method
                Console.WriteLine("Called anonymous method!\n");
            };

            Console.WriteLine("withAnonymousMethod() =>");
            withAnonymousMethod();


            Console.WriteLine("RunSafe(anonymous method) =>");
            // eyni codu tekrar yaziriqsa, bu methodu anonym yox adli method kimi istifade etmeliyik
            // anonym methodlari 1 defe istifade edilecekse yazilir.
            RunSafe(delegate
            {
                Console.WriteLine("Called anonymous method!\n");
            });

            Console.ReadKey();
        }

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
