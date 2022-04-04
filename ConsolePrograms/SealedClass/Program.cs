using System;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }


    sealed class SealedClass
    {
        // Sealed class-dan miras almaq olmur.
        // Bunun proqramimizi, mehsulumuzu qorumaq ucun edirik.
        // bezen bele mohurlemek lazim olur ki, kimse classimizdan(modelimizden)
        // miras alib inkisaf etdirib satisa cixarib,
        // bizim satisimizin qarsisina kecmesin.

        // Kiminse verdiyi .dll file-ni (class library)
        // oz proqramimizda istifade edende onun yazdigi class-i,
        // public memberlerini methodlarini goruruk.
        // Amma hemin methodun icinde yazilanlari gormuruk
        // ve deyise bilmirik. Sadece istidafe ede bilirik.

        // Miras ala bilirik,
        // Amma Sealed olarsa miras da ala bilmirik.
    }

    // Miras almaq olmur.

    //class TringInheritedFromSealedClass: SealedClass
    //{

    //}
}
