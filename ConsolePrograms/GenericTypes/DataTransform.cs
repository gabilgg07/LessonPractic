using System;
// .Reverse() methodu ucun:
using System.Linq;

namespace GenericTypes
{
    public class DataTransform
    {
        public DataTransform()
        {
        }

        // Generic olmayan class-da generic method yazanda
        // methodun adinindan sonra <T> yazilmalidir:
        public string Reverse<T>(T value)
            // gonderilen type-in referance ve ya value type olmasini da idare ede bilirik:
            // where T : struct // only value types
            // where T : class // only referance types

            // yaratdigimiz her hansi type-i da sece bilerik ki,
            // ancaq bu tip ve bu tipden torenmisleri qebul et:
            where T : Entity // only drived from Entity types

            // eger hem de bu tipin(Entity) bos constuctor-u olmalidi demek isteyirikse:
            , new() // yazmaliyiq - and has empty constructor

            //where T : Entity, new()
        {
            // Asagidaki method elimizdeki array-e mudaxile edir deyisir.
            //Array.Reverse(arr);

            // Linq-in verdiyi .Reverse() -> methodu ise yeni array qaytarir,
            // bizim array-i deyismir.
            return string.Join("", value.ToString().ToCharArray().Reverse());
        }
    }
}
