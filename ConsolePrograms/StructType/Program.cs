using System;

namespace StructType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lesson 74 Struct

            Console.WriteLine("==== Stuct Type ====");

            // reference type-larda
            PointClass pointClass = new PointClass();
            // kimi yazilisa ehtiyac var.

            // value type-larda ise yoxdu:

            PointStuct pointStuct;

            pointStuct.x = 6;

            Console.WriteLine($"New operatorundan istifade etmeden struct-dan variable yaradildi\n" +
                $" ve parametrlerinden birine 6 menimsedildi, pointStuct.x: {pointStuct.x}");

            #endregion

            #region Difference Class And Struct

            // 3:
            StructsDiff a = new StructsDiff(20, 20);
            StructsDiff b = a;
            a.x = 100;

            Console.WriteLine($"Struct Type: b.x = {b.x}");

            // 4:
            StructsDiff c;
            c.x = 50;

            // c2, c3: 
            ClassesDiff cA = new ClassesDiff(20, 20);
            ClassesDiff cB = cA;

            cA.x = 100;

            Console.WriteLine($"Class Type: cB.x = {cB.x}");

            // 13, 14: Nullable ola bilmesi:
            StructsDiff? structsDiff = null;

            Console.WriteLine($"Null Struct = >>{structsDiff}<<");

            // ----------------------------------------


            #endregion

            Console.ReadKey();
        }
    }

    #region Lesson 74 Struct

    // Point  -tercume-> noqte (burda Koordinant noqtesi)

    // class -> reference type
    // -> default-u null-di
    class PointClass
    {
        public int x;
        public int y ;

    }

    // struct -> value type
    // -> default-u her icindeki type-larin oz defaultlari. 
    struct PointStuct
    {
        // Constructor-u mutleq fildleri menimsetmek lazim.
        // Bos constructor yaratmaq olmur! 
        public PointStuct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public PointStuct(int x):this(x,x)
        {
        }

       public int x;
        public int y;
    }

    #endregion

    #region Difference Class And Struct

   
    //struct StructsDiff
    // 5:
    //struct StructsDiff //: TestInheritedFromClass => error
    //struct StructsDiff //: TestInheritedFromStruct => error

    // 8: 
    //abstract struct StructsDiff => error

    // 12: 
     struct StructsDiff: IInterfaceForStruct
    {
        // 1. Stuct-in default constructor-u ve ya destructoru olmur.
        // 2. Constructor yazanda mutleq parametrlerle yazilmalidir.

        // 3. Value type-dir ve menimsedilende kopyalanir.

        // 4. new operatorundan istifade etmeden de obyekt yaratmaq olur.

        // 5. basqa struct ve ya class-dan hec vaxt miras almir.
        // 6. ve ya class-lara da miras vermir.

        // 7. Butun sruct-lar System.Object-den miras almis
        // System.ValueType-dan miras alirlar.

        // 8. Struct tipler abstrakt ola bilmirler
        // ve hemise birbasa sealed olurlar.

        // 9. Memberleri protected ve ya protected internal olmurlar.

        // 10. Function memberleri abstract ve ya virtual ola bilmirler,
        // 11. override metodlar ise ancaq System.ValueType-indan gelen methodlardir.

        // 12. Interfaceler istifade ede biler.

        // 13. Nullable ola bilir, yeni ? isaresi qoymaqla sonuna,
        // 14. nullable olduqdan sonra null menimsetmek olur.

        // Istifade meqsedleri:
        // a. Mentiqi olaraq tek bir deyeri temsil etmelidir.(int, double ve s. kimi).
        // b. Deyisilmez olmalidir.
        // c. tez-tez boxin, unboxing edilmemelidir.

        public int x, y;

        // 9: 
        //protected int x, y;
        //protected internal int x, y;

        // 10:

        //abstract public void StructFuction() => error
        //{

        //}

        //virtual public void StructFuction()
        //{

        //}

        public void StructFuction()
        {

        }

        // 11:

        public override string ToString()
        {
            return base.ToString();
        }



        // 1:
        //public StructsDiff()
        //{

        //}


        // 2: constructor ancaq parametrle:
        public StructsDiff(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct TestInheritedFromStruct
    {

    }

    // 6: 
    //class ClassesDiff //:ForTestInheritedFromStruct => error
    // c4:
    class ClassesDiff : TestInheritedFromClass
    {
        // c1: Class-in default constructor-u ve ya destructoru olur.

        // c2: Reference type-dir ve menimsedilende eyni referansdan istifade edir.

        // c3: obyekt yaradanda(instance) new operatorundan istifade olunmalidir.

        // c4: basqa class-lardan miras ala bilir.
        // c5: ve basqa class-lara da miras vere bilir.

        // c6: Abstract ola bilirler,
        // c7: evveline sealed artirilarsa sealed olurlar.

        public int x, y;

        // c1: constructor
        public ClassesDiff()
        {

        }

        // c1: destructor
        ~ClassesDiff()
        {

        }

        public ClassesDiff(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    // c6: 

    abstract class TestInheritedFromClass
    {

    }

    // c5:
    class TestInheritedForClass : ClassesDiff
    {

    }

    interface IInterfaceForStruct
    {

    }

    // c7: 
    sealed class ClassWithSealed
    {

    }

    #endregion

}
