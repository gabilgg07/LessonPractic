using System;

namespace StructType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Stuct Type ====");

            // reference type-larda
            PointClass pointClass = new PointClass();
            // kimi yazilisa ehtiyac var.

            // value type-larda ise yoxdu:

            PointStuct pointStuct; 

            Console.ReadKey();
        }
    }

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
}
