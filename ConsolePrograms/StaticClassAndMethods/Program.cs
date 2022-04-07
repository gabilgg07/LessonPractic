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
}
