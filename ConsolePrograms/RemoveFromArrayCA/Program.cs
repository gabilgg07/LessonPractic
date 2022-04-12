using System;
using System.Collections;

namespace RemoveFromArrayCA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Array-den elave olaraq bir de Collection-larimiz var.

            Suret baximindan Array-ler Collection-lardan daha suretlidir.
            Sebebi Array-de yaddas sahesinde suurlu sekilde konkret ardicil yer tutulur.
            Collection-larda ise elave etme mehdudiyyeti yoxdur deye,
            her elave olunan yeni elemen ferli yaddas sahesine dusur.
            Komkret elave olunacaqlarin sayi olmadigindan ardicilligi qoruya bilmir.

            Arrayda elementeri uzerinde emeliyyat aparmaq ucun tez tapa bilir.
            Collectionlar da ise heresi bir terefde oldugundan gec tapir.
            Xaotiklik var.

            Arrayden antivirus kimi proqramlaarda istifade olunur.
            -> Miqdarindan emin oldugumuz informasiya, data ve s ucun
            fiksid olan array-den istifade edilir.

            Collectionlardan ise daha cox informasiya sistemlerinde.
            Emin deyilikse collectionlardan.

            Collection-lar uzerinde ama emeliyyat aparmaq daha rahatdir.
            Array-a nisbeten 1 setirlik kodlarla hell etmek olur.

            
            Collection-larin 2 novu var:
            Generic collections, Non-generic collections.

            Generic non-generic-den 8 qat daha suretlidir.
            Sebeb non-generic-de her sey butun tiplerin
            ana klasi olan object kimi goturulur.
            Ona gore elementlerinden istifade edende elave olaraq
            boxin-unboxin emeliyyatlarindan da istifade edilir.
             */
            ArrayList list = new ArrayList();

            list.Add(6);
            list.Add(true);
            list.Add(DateTime.Now);
            list.Add("String anything...");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void RemoveFromArray()
        {
            int[] arr = new int[6];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;

            Console.WriteLine("---- arr ----");
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }

            int removedIndex = 3;


            for (int i = removedIndex - 1; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("---- changed arr ----");
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }

            int[] newArr = new int[arr.Length - 1];

            Array.Copy(arr, newArr, newArr.Length);

            Console.WriteLine("---- new arr ----");

            foreach (var num in newArr)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("==== end ====");
        }
    }
}
