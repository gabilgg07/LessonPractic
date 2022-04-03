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

            // Nullable ola bilmesi:
            StructsDiff? structsDiff = null;

            Console.WriteLine($"Null Struct = >>{structsDiff}<<");

            // ----------------------------------------

            StructsDiff a = new StructsDiff(20, 20);
            StructsDiff b = a;
            a.x = 100;

            Console.WriteLine($"Struct Type: b.x = {b.x}");

            ClassesDiff cA = new ClassesDiff(20, 20);
            ClassesDiff cB = cA;

            cA.x = 100;

            Console.WriteLine($"Class Type: cB.x = {cB.x}");

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


    struct StructsDiff
    {
        // Stuct-in default constructor-u ve ya destructoru olmur.
        // Constructor yazanda mutleq parametrlerle yazilmalidir.

        // Value type-dir ve menimsedilende kopyalanir.

        // new operatorundan istifade etmeden de obyekt yaratmaq olur.

        // basqa struct ve ya class-dan hec vaxt miras almir.
        // ve ya class-lara da miras vermir.
        // Butun sruct-lar System.Object-den miras almis
        // System.ValueType-dan miras alirlar.

        // Struct tipler abstrakt ol bilmirler
        // ve hemise birbasa sealed olurlar.

        // Memberleri protected ve ya protected internal olmurlar.

        // Function memberleri astract ve ya virtual ola bilmirler,
        // override metodlar ise ancaq System.ValueType-indan gelen methodlardir.

        // Interfaceler istifade ede biler.

        // Nullable olaa bilir, yeni ? isaresi qoymaqla sonuna,
        // nullable olduqdan sonra null menimsetmek olur.

        // Mentiqi olaraq tek bir deyeri temsil etmelidir.(int, double ve s. kimi).
        // Deyisilmez olmalidir.
        // tez-tez boxin, unboxing edilmemelidir.

        public int x, y;

        // constractute ancaq parametrle:
         public StructsDiff(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class ClassesDiff
    {
        // Class-in default constructor-u ve ya destructoru olur.

        // Reference type-dir ve menimsedilende eyni referansdan istifade edir.

        // obyekt yaradanda(instance) new operatorundan istifade olunmalidir.

        // basqa class-lardan miras ala bilir.
        // ve basqa class-lara da miras vere bilir.

        // Abstract ola bilirler,
        // evveline sealed artirilarsa sealed olurlar.

        public int x, y;

        public ClassesDiff()
        {

        }

        public ClassesDiff(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


    #endregion

}
