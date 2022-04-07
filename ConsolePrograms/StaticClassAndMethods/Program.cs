using System;

namespace StaticClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeChecker typeChecker = new TypeChecker();

            AddStudent(-9);

            AddTeacher(7);

            Console.WriteLine("Next ->");
            Console.ReadKey();


            // Static class-dan her hansi memberini ilk defe cagiranda
            // instance (constructor)1 defe isleyir.
            // Sonra butun memberleri o referance-a muraciet edir.


            StaticClass.StaticNum = 6;

            Console.ReadKey();

            StaticClass.FirstStaticMethod();

            StaticClass.StaticStr = "test";

            string str = StaticClass.StaticStr;

            StaticClass.SecondStaticMethod(str);

            Console.ReadKey();
        }

        private static void AddTeacher(double id)
        {
            TypeChecker typeC = new TypeChecker();

            // TypeChecker.IsNegative(id) -> static method
            // bir basa class uzerinden cagrilir.

            // typeC.IsZero(id) -> non-static method
            // obyekt(nusxe) uzerinden cagrilir.
            // Buna gorede mutleq nusxe yaradilmalidir(instance).

            if (TypeChecker.IsNegative(id)|| typeC.IsZero(id))
            {
                Console.WriteLine($"Id uygun deyil: {id}");
            }
            else
            {
                Console.WriteLine("Her sey qaydasindadir/ AddTeacher");
            }
        }

        private static void AddStudent(int id)
        {
            // Non-static methoda gore gerek her yerde nusxe yaradasan:
            TypeChecker typeC = new TypeChecker();

            if (TypeChecker.IsNegative(id) || typeC.IsZero(id))
            {
                Console.WriteLine($"Id uygun deyil: {id}");
            }
            else
            {
                Console.WriteLine("Her sey qaydasindadir/ AddStudent");
            }
        }

        // Non-static memberleri ancaq
        // instance(obyekt) uzerinden cagirmaq olur.

        // Static-leri ise ancaq class adi uzerinden cagirmaq olur.

        // Her defe class-in 1 ve ya 2 methodunu isletmek ucun,
        // onun instance-ni (nusxesini yaratmaga deymez).
        // Her nusxe (obyekti) yarananda heap yaddasda
        // ona  yeni yer ayrilir.

        // Static olan yaddas sahesinde 1 yer tutur,
        //  instance ise her defesinde yeni yer tutur.

        // Bir class-da non-static member
        // olmayacaqsa static class etmek olar.

    }

    class TypeChecker
    {

        public TypeChecker()
        {
            Console.WriteLine("TypeChecker-den nusxes yaradildi.");
        }

        public static bool IsNegative(double value)
        {
            if (value < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPositive(double value)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsZero(double value)
        {
            if (value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    static class StaticClass
    {
        // static class icinde yalniz static olan,
        // parametr qebul etmeyen, private olan ve
        // yalnizca 1 constructor ola biler.

        static StaticClass()
        {
            Console.WriteLine("I am static class.");
        }

        // static clas icinde ancaq statik memberler ola biler:

        static public int StaticNum;

        static public string StaticStr { get; set; }

        static public void FirstStaticMethod()
        {
            Console.WriteLine("I am first statik method in Static Class.");
        }


        static public void SecondStaticMethod(string str)
        {
            Console.WriteLine($"I am second statik method in Static Class with: {str}");
        }
    }
}
