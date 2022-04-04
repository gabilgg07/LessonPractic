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
            #region Lesson 66

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
            Console.WriteLine();

            // --------------------------------------------------------------


            // ============== Protected Method =================

            Parent parent = new Parent();

            // Protected method obyekt terefinden cagirila bilmez,
            // ancaq yazildigi class icerisinde,
            // ve ya miras verdiyi classlarda istifadesi mumkundur

            // parent.ProtectedMethodInParent();

            Child child = new Child();
            child.MethodInChildCallingProdectedMethodOfParent();
            Console.WriteLine();
            #endregion

            #region Lesson 89

            // --------------------------------------------------------------


            // Protected internal => programin ozunde internal, xaricinde
            // protected olaraq fealiyyet gosterir.
            // 

            // Protected Internal Method eyni programda hem mirasda,
            // hem de diger class daxilinde istifade edile biler(internal):

            // ============== Protected Internal Method Same Assembly =================

            parent.ProtectedInternalMethodInParent();
            Console.WriteLine();
            child.ProtectedInternalMethodInChild();
            Console.WriteLine();

            // ============== Protected Internal Method Same Assembly From Parent =================

            child.MethodInChildCallingProdectedInternalMethodOfParent();
            Console.WriteLine();

            // ============== Protected Internal Method Other Assembly =================

            // Lakin basqa proqramda miras verdiyi
            // class daxilinde istifade etmek olur,

            ChildFromOtherAssemblyClass cFOAC = new ChildFromOtherAssemblyClass();

            cFOAC.CallProtectedInternalMethodFromOtherAssemblyParentClass();
            Console.WriteLine();

            // miras vermediyi diger class daxilinde(obyekt de) olmur(protected).

            //publicClass.ProtectedInternalMethodInPC()


            // --------------------------------------------------------------


            // Protected private => proqramin ozunde protected,
            // xaricinde private kimi ozunu gosterir.

            // Program oz classinda Protected kimi:
            //parent.ProtectedPrivateMethodInParent();

            // Child terefinden istifade edilmekle: 
            child.CallParentProtectedPrivateMethod();
            Console.WriteLine();

            // Diger programda private kimi

            //publicClass.ProtectedPrivateMethodInPC();

            // Diger proqramin classindan miras goturmus classin
            // miras goturduyu protected internal methodunun
            // protected private methodunu cagirmasi methodunu
            // ozunde cagirmasi ile:


            cFOAC.CallProtectedPrivateMethodFromOtherAssemblyParentClass();

            #endregion

            Console.ReadKey();

        }
    }

    class Parent
    {
        protected void ProtectedMethodInParent()
        {
            Console.WriteLine("I am protected method in Parent class.");
        }

        protected internal void ProtectedInternalMethodInParent()
        {
            Console.WriteLine("I am protected internal method in Parent class.");
        }

        protected private void ProtectedPrivateMethodInParent()
        {
            Console.WriteLine("I am protected private method in Parent class.");
        }

    }

    class Child : Parent
    {
        public void MethodInChildCallingProdectedMethodOfParent()
        {
            Console.Write($" I call my parent's\n protected method: ");
            ProtectedMethodInParent();
        }

        public void MethodInChildCallingProdectedInternalMethodOfParent()
        {
            Console.Write($" I call my parent's\n protected internal method: ");
            ProtectedInternalMethodInParent();
        }

        protected internal void ProtectedInternalMethodInChild()
        {
            Console.WriteLine("I am protected internal method in Child class.");
        }

        public void CallParentProtectedPrivateMethod()
        {
            Console.Write("I call my parent protected private method: ");
            base.ProtectedPrivateMethodInParent();
        }
    }

    class ChildFromOtherAssemblyClass : PublicClass
    {
        public void CallProtectedInternalMethodFromOtherAssemblyParentClass()
        {
            Console.Write("I call protected internal method of \nother assembly class: ");

            base.ProtectedInternalMethodInPC();
        }

        public void CallProtectedPrivateMethodFromOtherAssemblyParentClass()
        {
            Console.Write("I call protected private method of \nother assembly class: ");

            base.CallMyProtectedPrivateMethodInPC();
        }
    }
}
