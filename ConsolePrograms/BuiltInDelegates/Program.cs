using System;

namespace BuiltInDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegate-ler - menasi temsilchi,
            // ozunde methodu ve ya methodlar cemini saxlayir.

            // Delegate methodu ozunde saxlayan bir type-di.
            // Variable type-i.

            // Delegate uzerinde o methodlar cemlene bilir ki,
            // onlarin geri donus (return) type-lari da eyni olmalidir ve
            // qebul etdikleri parametrlerin sayi ve ardicilligi da eyni olmalidir. 

            // Buid in delegateler 3 curdu:
            // 1. Action delegates,
            // 2. Func delegates,
            // 3. Predicate delegates.

            // Her hasi bir type qaytarmayan, yeni void olan methodlar,
            // Action delegate-de saxlanilir.

            // Parametr olmayan methodlarin action-da saxlanmasi:
            Action action = VoidMethodNoParam1;

            // eyni type methodlarin cemlenmesi:
            action += VoidMethodNoParam2;

            // delegate-in cagrilmasi:
            Console.WriteLine(" action.Invoke() usulla cagrilma:");
            action.Invoke();
            // ve ya
            Console.WriteLine(" action() usulla cagrilma:");
            action();

            // Parametrleri olan methodlarin saxlanmasi:
            Action<string, int> actionWithParam = VoidMethodWithParam1;
            actionWithParam += VoidMethodWithParam2;

            Console.WriteLine("Action with parametrs");
            actionWithParam("1-ci", 2);

            Console.WriteLine("Func delegates:");

            Func<string> funcNoParm = ReturnMethodNoParam1;
            funcNoParm += ReturnMethodNoParam2;

            // en sonda elave edilmis methodun return valuesini qaytarir:
            string result = funcNoParm();
            Console.WriteLine($"And last method's retunt type: {result}\n\n");

            Console.WriteLine("Func delegate with parametrs: ");

            Func<string, int, string> funcWithParm = ReturnMethodWithParam1;
            funcWithParm += ReturnMethodWithParam2;

            result = funcWithParm("3-ci", 4);
            Console.WriteLine($"And last method's retunt type: {result}\n\n");

            Console.WriteLine("Predicate delegate");

            Predicate<int> predicate = MethodForPredicaate;

            bool isPositive = predicate(5);

            Console.WriteLine($"isPositive(result predicate) -> {isPositive}\n");

            Action actionSendingInMethod = ReturnExceptionMethod;

            RunSafe(actionSendingInMethod);

            Console.WriteLine("\nPress any key to out ...");
            Console.ReadKey(true);
        }

        static void VoidMethodNoParam1()
        {
            Console.WriteLine("Void Method 1 without parametr for Action delegate\n");
        }

        static void VoidMethodNoParam2()
        {
            Console.WriteLine("Void Method 2 without parametr for Action delegate\n");
        }


        static void VoidMethodWithParam1(string str, int x)
        {
            Console.WriteLine($"Void Method 1 with parametrs: " +
                $"string -> {str} and int -> {x} for Action delegate\n");
        }

        static void VoidMethodWithParam2(string str, int x)
        {
            Console.WriteLine($"Void Method 2 with parametrs: " +
                $"string -> {str} and int -> {x} for Action delegate\n");
        }


        static string ReturnMethodNoParam1()
        {
            Console.WriteLine("Return Method 1 without parametr for Func delegate\n");
            return "return string with ReturnMethodNoParam1 method";
        }

        static string ReturnMethodNoParam2()
        {
            Console.WriteLine("Return Method 2 without parametr for Func delegate\n");
            return "return string with ReturnMethodNoParam2 method";
        }


        static string ReturnMethodWithParam1(string str, int x)
        {
            Console.WriteLine($"Return Method 1 with parametrs: " +
                $"string -> {str} and int -> {x} for Func delegate\n");
            return "return string with ReturnMethodWithParam1 method";
        }

        static string ReturnMethodWithParam2(string str, int x)
        {
            Console.WriteLine($"Return Method 2 with parametrs: " +
                $"string -> {str} and int -> {x} for Func delegate\n");
            return "return string with ReturnMethodWithParam2 method";
        }


        static bool MethodForPredicaate(int x)
        {
            Console.WriteLine($"Parametr in MethodForPredicate: {x}\n");

            if (x >= 0)
            {
                return true;
            }
            return false;
        }

        static void RunSafe(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReturnExceptionMethod()
        {
            int x = 1 / int.Parse("0");

            Console.WriteLine(x);

            Console.WriteLine("Method working");
        }
    }
}
