using System;
using System.Collections;
using System.Diagnostics;

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
            Collection-larda sira qorunmur, sepelenmis sekilde yazilirlar yaddasda.
            Ona gore oxudularda, hansini tez tapdi onu getirir.

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

            Collectionlar Array-lere(massivlere) cox benzeyir ama fleksibldi.

            --------------------------------------------------------------------
            
            Collection-larin 2 novu var:
            Generic collections, Non-generic collections.

            Generic non-generic-den 8 qat daha suretlidir.
            Sebeb non-generic-de her sey butun tiplerin
            ana klasi olan object kimi goturulur.
            Ona gore elementlerinden istifade edende elave olaraq
            boxin-unboxin emeliyyatlarindan da istifade edilir.

            --------------------------------------------------------------------

            ArrayList - indeksle isleyen bir collection-du,
            bir de var key, value ile isleyen. Misal HashTable.
            ArrayList.Add(value) methodunda bizden sadece value isteyir
            ve onlari add etdikce indeksleyir.

            HashTable.Add(key, value) da ise key ve value teleb edir.
            Yazilan key-e yazilan valune teyin edir.
            key-value pair => key-value birlesmesi.
            Eyni key-i tekrar add etmek exeption(error) verir.

            ArrayList-de oxuyanda sira nomresine gore oxuyur,
            HashTable-da ise key-e esasen.
             */

            Hashtable hTable = new Hashtable();

            hTable.Add("birinci","on bir");
            hTable.Add(2,"on iki");
            hTable.Add("ucuncu",13);
            hTable.Add(4,14);
            //hTable.Add(4,3); => eyni key yazmaq olmaz.

            Console.WriteLine(hTable["birinci"]);
            Console.WriteLine(hTable[2]);
            Console.WriteLine(hTable["ucuncu"]);
            Console.WriteLine(hTable[4]);

            Console.WriteLine("-----------------------");

            Hashtable hashtable = new Hashtable();

            string[] profession = new string[] { "analitik", "informasiya muhendisi" };

            hashtable.Add("D6TFH89","Asif Kerimov");
            hashtable.Add("64TFH8O","Eli Semedov");
            hashtable.Add("YTF5H39","Sevda Besirzade");
            hashtable.Add("54TFG89",profession);

            foreach (var key in hashtable.Keys)
            {
                object value = hashtable[key];

                if (value is string[] list)
                {
                    string joinedArray = string.Join(", ", list);

                    Console.WriteLine($"{key} {joinedArray}");
                }
                else
                {
                    Console.WriteLine($"{key} {value}");
                }
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

        private static void RemoveFromArrayList()
        {
            ArrayList list = new ArrayList();

            list.Add(6);
            list.Add(true);
            list.Add(DateTime.Now);
            list.Add("String anything...");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ArrayList ls = new ArrayList();

            ls.Add(1);
            ls.Add(2);
            ls.Add(3);
            ls.Add(4);
            ls.Add(5);
            ls.Add(6);

            Console.WriteLine("--- Print ---");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            ls.RemoveAt(2);

            Console.WriteLine("--- Print Removed 2 index ---");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            ls.Clear();

            Console.WriteLine("--- Print Clear ---");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
