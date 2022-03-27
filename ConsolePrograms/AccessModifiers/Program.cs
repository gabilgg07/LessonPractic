using System;
// Diger programdaki classlara erise bilmek ucun:

// Bu programin uzerinde sag clickden => add reference-e klikleyib
// Diger programi add edirik.

// Diger proqramin namespacesini using edirik.
using AccessModifierTestingLibrary; 

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 6;
            int c = 3;

            Calculator calc = new Calculator();

            // ============== Private Method =================
            // Topla() methodu Calculator class-i icinde default olaraq private-dir.
            // Ona gore burda cagirmaq mumkun deyil!

            //int sumAB = calc.Topla(a, b); => error


            // Asagidak PrivateMethodInPC methodu oz class-i icerisinde private oldugu ucun,
            // basqa hec bir yerde istifade etmek mumkun deyil!

            // publicClass.PrivateMethodInPC();


            // ============== Internal Method Same Assembly =================
            // ToplaThree() methodu ise Calculator class-i icinde internal-di.
            // Ona gore burda, yeni eyni Program(Assembly) icerisinde isletmek olur:

            int sumABC = calc.ToplaThree(a, b, c);
            Console.WriteLine($"sumABC = {sumABC}");


            // ============== Internal Class Other Assembly =================
            // Altdaki InternalClass class-i oz assembly-sinde(proqraminda)
            // default olaraq internal oldugu ucun,
            // bu proqramda istifade oluna bilmir!

            // InternalClass internalClass = new InternalClass(); => error


            // ============== Public Class Other Assembly =================
            // Asagidaki PublicClass class-i ise oz programinda public oldugu ucun
            // bu proqramda istifade etmek mumkundur.

            PublicClass publicClass = new PublicClass();


            // ============== Internal Method Other Assembly =================
            // Asagidak InternalMethodInPC methodu oz class-i icerisinde internal oldugu ucun,
            // basqa hec bir proqramda istifade etmek mumkun deyil!

            // publicClass.InternalMethodInPC();


            // ============== Public Method Other Assembly =================
            // Asagidaki PublicMethodInPC methodu oz public class-inda public oldugu ucun,
            // diger proqram daxilinde de cagirila bilir.

            publicClass.PublicMethodInPC();


            // --------------------------------------------------------------


            // ============== Protected Method =================

            Parent parent = new Parent();

            // Protected method obyekt terefinden caagrila bilmez,
            // ancaq yazildigi class icerisinde,
            // ve ya miras verdiyi classlarda istifadesi mumkundur

            // parent.ProtectedMethodInParent();

            Child child = new Child();
            child.MethodInChildCallingProdectedMethodOfParent();


            Console.ReadKey();

        }
    }

    class Parent
    {
        protected void ProtectedMethodInParent()
        {
            Console.WriteLine("I am protected method in Parent class.");
        }
    }

    class Child : Parent
    {
        public void MethodInChildCallingProdectedMethodOfParent()
        {
            Console.Write($" I call my parent's\n protected method: ");
            ProtectedMethodInParent();
        }
    }
}
