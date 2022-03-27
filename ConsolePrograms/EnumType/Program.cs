using System;

namespace EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Enum type ====");

            Console.WriteLine(GetCoffeeInfoWithEnum(Coffee.Americano));

            BloodGroup bloodGroup = BloodGroup.AB_RhD_positive; // default (int) 4 byte

            Coffee c = Coffee.Cappuchino; // byte toremesi oldugundan 1 byte yer tutur.

            Console.WriteLine(bloodGroup);
            Console.WriteLine(c);

            Console.ReadKey();
        }

        static string GetCoffeeInfoWithEnum(Coffee coffee)
        {
            switch (coffee)
            {
                case Coffee.Espresso:
                    return "Espresso-Info";
                case Coffee.DoubleEspresso:
                    return "DoubleEspresso-Info";
                case Coffee.Americano:
                    return "Americano-Info";
                case Coffee.Latte:
                    return "Latte-Info";
                case Coffee.Cappuchino:
                    return "Cappuchino-Info";
                case Coffee.Breve:
                    return "Breve-Info";
                case Coffee.Macachino:
                    return "Macachino-Info";
                case Coffee.RedEye:
                    return "RedEye-Info";
                case Coffee.BlackEye:
                    return "BlackEye-Info";
                default:
                    return "not any coffee";
            }
        }
    }
}
