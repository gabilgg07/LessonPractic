using System;

namespace Folder17Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnumIsDefined();

            //==================================================================

            // Bitwise operatorlar
            // ancaq int type-la isleyir.
            // Binari seviyyede alt-alta yoxlayir.

            int a = 12; // binary : 1100
            int b = 5;  // binary : 0101

            // & (AND) her hansi biri 0 olan 0 qaytarir,
            //        her ikisi 1 olan 1 qaytarir:
            Console.WriteLine($"a & b = {a & b}\n"); // 1100
                                                   // 0101
                                                   // ____
                                                   // 0100 => cavab 4;

            // | (OR) her hansi biri 1 olan 1 qaytarir,
            //       her ikisi 0 olan 0 qaytarir:
            Console.WriteLine($"a | b = {a | b}\n"); // 1100
                                                   // 0101
                                                   // ____
                                                   // 1101 => cavab 13;

            // ^ (XOR) her hansi biri 1 olan 1 qaytarir,
            //        her ikisi 0 olan 0 qaytarir,
            //        her ikisi 1 olan 0 qaytarir:
            Console.WriteLine($"a ^ b = {a ^ b}\n"); // 1100
                                                     // 0101
                                                     // ____
                                                     // 1001 => cavab 9;

            // ~ (flipping) signed(isareli) binary numbere cevirir,
            // yeni, 4 byte-liq,=> 16 bitlik intde
            // butun bitleri eksine cevirir:
            Console.WriteLine($"~ b = {~ b}\n");     // 0000.0000.0000.0101
                                                     // ____
                                                     // 1111.1111.1111.1010 => cavab -6
                                                     // (Binary signed 2's complement);

            // << (Left Shift) verilen eded qeder binary formada sola surusdurur,
            // yeni, 2 yazanda sonuna iki sifir(00) elave edir:
            Console.WriteLine($"b << 2 = {b << 2}\n");  // 0000.0101
                                                        // ____
                                                        // 0001.0100 => cavab 20

            // >> (Right Shift) verilen eded qeder binary formada saga surusdurur,
            // yeni, 2 yazanda sonundan iki eded silir:
            Console.WriteLine($"b >> 2 = {b >> 2}\n");  // 0101
                                                        // ____
                                                        // 0001 => cavab 1

            Console.ReadKey();
        }

        private static void EnumIsDefined()
        {

        lblReqem:
            Console.WriteLine(" 5-e kimi her hansi bir reqemi daxil edin:");
            string reqem = Console.ReadLine();
            Reqemler number = Reqemler.Bir;

            // Adi Reqemler olan enum taypina uygundurmu deye cavab qaytarir:
            if (Enum.IsDefined(typeof(Reqemler), reqem))
            {
                number = (Reqemler)Enum.Parse(typeof(Reqemler), reqem);
            }
            else
            {
                Console.WriteLine("Duzgun yazin!");
                goto lblReqem;
            }

            Console.WriteLine($"Secdiyiniz reqem: {number}");

        }
    }

    enum Reqemler
    {
        Bir=1,
        Iki,
        Uc,
        Dord
    }
}
