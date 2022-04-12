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
            Generic typelardar boxing-den soz gede bilmez.

            --------------------------------------------------------------------

            ArrayList - indeksle isleyen bir collection-du,
            bir de var key, value ile isleyen. Misal HashTable.
            ArrayList.Add(value) methodunda bizden sadece value isteyir
            ve onlari add etdikce indeksleyir.

            HashTable.Add(key, value) da ise key ve value teleb edir.
            Yazilan key-e yazilan valune teyin edir.
            key-value pair => key-value birlesmesi.
            Eyni key-i tekrar Add etmek exeption(error) verir.

            ArrayList-de oxuyanda sira nomresine gore oxuyur,
            HashTable-da ise key-e esasen.
             */

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

        private static void RemoveFromArrayListNonGenericCollection()
        {
            ArrayList list = new ArrayList();

            //  Add(object value);
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

            // .RemoveAt(index) -> indekse gore silir
            ls.RemoveAt(2);

            Console.WriteLine("--- Print Removed 2 index ---");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            // .Clear() -> butun temizleyir.
            ls.Clear();

            Console.WriteLine("--- Print Clear ---");

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashTableNonGenericCollection()
        {
            Hashtable hTable = new Hashtable();

            // .Add(object key, object value);
            hTable.Add("birinci", "on bir");
            hTable.Add(2, "on iki");
            hTable.Add("ucuncu", 13);
            hTable.Add(4, 14);
            //hTable.Add(4,3); => eyni key yazmaq olmaz.

            // hTable[key] -> key-e esasen value
            Console.WriteLine(hTable["birinci"]);
            Console.WriteLine(hTable[2]);
            Console.WriteLine(hTable["ucuncu"]);
            Console.WriteLine(hTable[4]);

            Console.WriteLine("-----------------------");

            Hashtable hashtable = new Hashtable();

            string[] profession = new string[] { "analitik", "informasiya muhendisi" };

            hashtable.Add("D6TFH89", "Asif Kerimov");
            hashtable.Add("64TFH8O", "Eli Semedov");
            hashtable.Add("YTF5H39", "Sevda Besirzade");
            hashtable.Add("54TFG89", profession);

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
        }

        private static void SortedListNonGenericCollection()
        {
            SortedList sorted = new SortedList();

            // key eyni type olmalidi ki, siralaya bilsin.
            // string type-i ASCII-ye esasen siralayir.
            sorted.Add("33", "otuz uc");
            sorted.Add("55", "elli bes");
            sorted.Add("44", "qirx dord");

            foreach (var k in sorted.Keys)
            {
                object value = sorted[k];

                Console.WriteLine($"{k} {value}");
            }

            SortedList nums = new SortedList();

            // number type-lari ise kemiyyete gore siralayir
            nums.Add(4, "dord");
            nums.Add(1, "bir");
            nums.Add(32, "otuz iki");
            nums.Add(13, "on uc");

            foreach (var k in nums.Keys)
            {
                Console.WriteLine($"{k} -> {nums[k]}");
            }
        }

        private static void StackAndQueueNonGenericCollections()
        {
            Console.WriteLine("----- Stack ----");

            // Stack - yigin, deste (torba, qutu mentiqi)
            // Lifo - last      in     first    out
            //        sonuncu   giren  birinci  cixar

            Stack stc = new Stack();

            // push - itelemek (torbaya itelemek)

            stc.Push(7);
            stc.Push(67);
            stc.Push(4);
            stc.Push(56);

            // pop - cixartmaq sonuncu qoyulani.
            object x1 = stc.Pop();
            Console.WriteLine(x1); // 56 sonuncu, 1-ci cixdi.

            object x2 = stc.Pop();
            Console.WriteLine(x2); // 4

            object x3 = stc.Pop();
            Console.WriteLine(x3); // 67

            Console.WriteLine("-----------------------");

            stc.Push(x2);
            stc.Push(x1);

            foreach (var x in stc)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            // Queue[kyu:] - sira, novbe (boru mentiqi)
            // Fifo - first  in     first  out
            //        1-ci   giren  1-ci   cixr
            Console.WriteLine("----- Queue ----");

            Queue queue = new Queue();

            // Enqueue - novbeye salmaq
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Firs queue:");

            foreach (var y in queue)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("Dequeued elements:");

            // Dequeue - siradan, novbeden cixartmaq
            object y1 = queue.Dequeue();
            Console.WriteLine(y1);

            object y2 = queue.Dequeue();
            Console.WriteLine(y2);

            object y3 = queue.Dequeue();
            Console.WriteLine(y3);

        }


    }
}
