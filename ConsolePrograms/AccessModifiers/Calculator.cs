using System;
namespace AccessModifiers
{
    // Class-larin default access modifier-i internaldir
    // yəni eyni program(assembly) icerisinde cagira bilerik.
     class Calculator
    // Class-lara private vermek olmur! (menasi yoxdu):
    // Class yaradilir ki basqa class-larda istifade edilsin.
    {
        //Access Modifier-i default olaraq private-dir.
        int Topla(int a, int b)
        {
            int s = a + b;
            return s;
        }

        // Access Modifier-ini internal etdik.
        internal int ToplaThree(int a, int b, int c)
        {
            // Topla() methodu default olaraq private oldugundan,
            // yalniz bu class daxilinde istifade oluna bilir.
            int s1 = Topla(a, b);
            int s2 = Topla(s1, c);
            return s2;
        }
    }

    struct CalculatorResult
    {
        public int num;
        public int prev;
        public int result;
    }
}
