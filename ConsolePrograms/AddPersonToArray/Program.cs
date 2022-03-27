using System;
using System.Threading;
using Helper;

namespace AddPersonToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.SetDefaults();

            int countOfPerson = GetCountOfPersons();

            Person[] people = new Person[countOfPerson];

            for (int i = 0; i < people.Length; i++)
            {
                string name = ConsoleHelper.GetStringFromConsole($"\n {i+1}. PersonName: ");
                string surname = ConsoleHelper.GetStringFromConsole($"\n {name}'s Surname: ");
                byte age = ConsoleHelper.GetByteNumFromConsole($"\n {name} {surname}'s Age: ", "a age");

                people[i] = new Person(name, surname, age);
            }

            Console.WriteLine("Siyahi -->");
            Console.ReadKey();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }


            //string name = ConsoleHelper.GetStringFromConsole("\n PersonName: ");
            //string surname = ConsoleHelper.GetStringFromConsole("\n PersonSurname: ");
            //byte age = ConsoleHelper.GetByteNumFromConsole("\n PersonAge: ", "a age");

            //Person person = new Person(name, surname, age);

            //Console.WriteLine(person);

            //string[] names = FillPersonsInArray(GetCountOfPersons());

            //Console.Clear();

            //ShowStringsWithOrder(names);

            //Console.WriteLine(">>  Next --> ");
            //Console.ReadKey();

            //Console.WriteLine("\n-------------------------------");


            //ShowStringsByRandomOrders(names);

            //Console.WriteLine("\n-------------------------------");


            //Console.WriteLine(">>  Next --> ");
            //Console.ReadKey();

            //ShowStringsWithRandomOrdersByTeacher(names);

            //Console.WriteLine("===============================");

            ////ShowRandomStringFromStrings(names);


            //Console.WriteLine(">>  Next --> ");
            //Console.ReadLine();

            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            //ConsoleHelper.ClearCurrentConsoleLine();

            //Console.WriteLine(">>  Next --> ");
            //Console.ReadKey();

            //WriteBigWordOnConsole();


            //Console.WriteLine(">>  Next --> ");
            //Console.ReadKey();


            //Console.Write($"Silmek istediyiniz setir sayini yazin. (Max: {Console.CursorTop}) ");
            //int countLine = ConsoleHelper.GetIntNumFromConsole();

            //try
            //{
            //    ConsoleHelper.ClearCurrentConsoleLineByCount(countLine);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Console.WriteLine(">>  End! ");
            Console.ReadKey();
        }

        public class Noqteler
        {
            public int start;
            public int end;
            public int top;
        }

        private static void WriteBigWordOnConsole()
        {

            Noqteler[][] noqtelers =
            {
                new Noqteler[] {
               new Noqteler(){
                   top = 6,
                    start = 6,
                    end = 8
                },
                new Noqteler()
                {
                    start = 14,
                    end = 16
                },
                new Noqteler()
                {
                    start = 21,
                    end = 23
                },
                new Noqteler()
                {
                    start = 29,
                    end = 30
                },
                new Noqteler()
                {
                    start = 34,
                    end = 35
                },
            },
                new Noqteler[] {
               new Noqteler(){
                   top = 7,
                    start = 5,
                    end = 6
                },
                new Noqteler()
                {
                    start = 8,
                    end = 9
                },
                new Noqteler()
                {
                    start = 13,
                    end = 14
                },
                new Noqteler()
                {
                    start = 16,
                    end = 17
                },
                new Noqteler()
                {
                    start = 21,
                    end = 22
                },
                new Noqteler()
                {
                    start = 23,
                    end = 24
                },
                new Noqteler()
                {
                    start = 34,
                    end = 35
                },
            },
                new Noqteler[] {
               new Noqteler(){
                   top = 8,
                    start = 5,
                    end = 6
                },
                new Noqteler()
                {
                    start = 8,
                    end = 9
                },
                new Noqteler()
                {
                    start = 13,
                    end = 17
                },
                new Noqteler()
                {
                    start = 21,
                    end = 23
                },
                new Noqteler()
                {
                    start = 29,
                    end = 30
                },
                new Noqteler()
                {
                    start = 34,
                    end = 35
                },
            },
                new Noqteler[] {
               new Noqteler(){
                   top = 9,
                    start = 5,
                    end = 6
                },
                new Noqteler()
                {
                    start = 8,
                    end = 9
                },
                new Noqteler()
                {
                    start = 13,
                    end = 14
                },
                new Noqteler()
                {
                    start = 16,
                    end = 17
                },
                new Noqteler()
                {
                    start = 21,
                    end = 22
                },
                new Noqteler()
                {
                    start = 23,
                    end = 24
                },
                new Noqteler()
                {
                    start = 29,
                    end = 30
                },
                new Noqteler()
                {
                    start = 34,
                    end = 35
                },
            },
                new Noqteler[] {
               new Noqteler(){
                   top = 10,
                    start = 6,
                    end = 8
                },
                new Noqteler()
                {
                    start = 13,
                    end = 14
                },
                new Noqteler()
                {
                    start = 16,
                    end = 17
                },
                new Noqteler()
                {
                    start = 21,
                    end = 22
                },
                new Noqteler()
                {
                    start = 24,
                    end = 25
                },
                new Noqteler()
                {
                    start = 29,
                    end = 30
                },
                new Noqteler()
                {
                    start = 34,
                    end = 35
                },
            },
                new Noqteler[] {
               new Noqteler(){
                   top = 11,
                    start = 8,
                    end = 9
                },
                new Noqteler()
                {
                    start = 13,
                    end = 14
                },
                new Noqteler()
                {
                    start = 16,
                    end = 17
                },
                new Noqteler()
                {
                    start = 21,
                    end = 24
                },
                new Noqteler()
                {
                    start = 29,
                    end = 30
                },
                new Noqteler()
                {
                    start = 34,
                    end = 38
                },
            }
            };

            Thread.Sleep(500);

            WritingCharByIntervalOnRow(noqtelers,7,9,11,1, symbolBackground: "_");

        }
        public static void WritingCharByIntervalOnRow(Noqteler[][] noqtelers,int backClrFon = 1,int clrFonText = 0,
            int clrText = 1, int backClrTExt = 2,  string symbolBackground = "0", string symbolText = " ")
        {
            Console.BackgroundColor = (ConsoleColor)backClrFon;
            Console.ForegroundColor = (ConsoleColor)clrFonText;
            for (int i = 0; i < Console.LargestWindowHeight * Console.LargestWindowWidth; i++)
            {
                Console.Write(symbolBackground);
            }


            Console.BackgroundColor = (ConsoleColor)backClrTExt;
            Console.ForegroundColor = (ConsoleColor)clrText;
            for (int i = 0; i < noqtelers.Length; i++)
            {
                Console.CursorTop = noqtelers[i][0].top;

                for (int x = 0; x < noqtelers[i].Length; x++)
                {
                    Console.CursorLeft = noqtelers[i][x].start;
                    for (int j = 0; j < noqtelers[i][x].end - noqtelers[i][x].start; j++)
                    {
                        Thread.Sleep(50);
                        Console.Write(symbolText);
                    }
                }
            }

        }



        private static void ShowStringsWithRandomOrdersByTeacher(string[] strings)
        {
            int[] randIndexes = new int[strings.Length];

            for (int i = 0; i < randIndexes.Length; i++)
            {
                randIndexes[i] = -10;
            }

            Random random = new Random();
            int emptyIndex = 0;

            do
            {
                reRand:
                int randInd = random.Next(0, strings.Length);
                if (Array.IndexOf(randIndexes, randInd) != -1)
                    goto reRand;
                randIndexes[emptyIndex] = randInd;

                emptyIndex = Array.IndexOf(randIndexes, -10);


            } while (emptyIndex != -1 );

            foreach (var index in randIndexes)
            {
                Console.WriteLine($">> {index}. {strings[index]}");
            }
        }

        private static void ShowStringsByRandomOrders(string[] strings)
        {
            int countStrings = strings.Length;
            int[] indexes = new int[strings.Length];

            // when indexes all values change -1 from default 0
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = -1;
            }
            Random random = new Random();

            int counter = 0;

            // when indexes with Default value(0)
            // int count0 = 0;

            while (countStrings>0)
            {
                int randomIndex = random.Next(0, strings.Length);

                // when indexes with Default value(0)
                //if (randomIndex == 0)
                //{
                //    count0++;
                //}

                if (Array.IndexOf(indexes, randomIndex)==-1

                    // when indexes with Default value(0)
                    //|| count0 == 1
                    )
                {
                    indexes[counter] = randomIndex;

                    counter++;
                    Console.WriteLine($">> {counter}. {strings[randomIndex]}");
                    
                    countStrings--;

                    // when indexes with Default value(0)
                    //if (count0 == 1)
                    //{
                    //    count0++;
                    //}
                }

            }
        }

        private static void ShowRandomStringFromStrings(string[] sts)
        {
            Random random = new Random();
           
            while (true)
            {
                int randomNum = random.Next(0, sts.Length);
                Console.WriteLine($">>{sts[randomNum]}<<");
                Console.ReadKey();
            }
        }

        private static void ShowStringsWithOrder(string[] names)
        {
            int counter = 0;
            foreach (var name in names)
            {
                counter++;
                Console.WriteLine($" {counter}. {name} ");
            }
        }


        private static string GetPersonNameByOrder(int o)
        {
        lblAddPersonName:
            Console.Write($"\n>> {o + 1}{DataHelper.SuffixOfNumberForAZ(o + 1)} adı daxil edin: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Trim().Length < 3 || name.Trim().IndexOf(" ") > -1)
            {
                Console.Clear();
                Console.WriteLine("\n>> Adda boşluq ola bilməz \n>> və ən azı 3 hərfdən ibarət olmalıdır, yenidən.. ");
                goto lblAddPersonName;
            }

            return name;
        }

        private static int GetCountOfPersons()
        {
        lblAddPersonCount:

            Console.Write("\n>> Əlavə etmək istədiyiniz person sayını daxil edin: ");

            string countPersonStr = Console.ReadLine();

            if (!(int.TryParse(countPersonStr, out int countPerson) && countPerson > 0))
            {
                Console.Clear();
                Console.WriteLine($"\n>> Say natural ədəd olmalıdır. \"{countPersonStr}\" natural ədəd deyil! Yenidən, ");
                goto lblAddPersonCount;
            }

            return countPerson;
        }

        private static string[] FillPersonsInArray(int personCount)
        {
            string[] names = new string[personCount];

            for (int i = 0; i < personCount; i++)
            {
                Console.Clear();
                names[i] = GetPersonNameByOrder(i);
            }

            return names;
        }


        private static void TestingNumSuffixAZ()
        {
            //Suffix yoxlanışı
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 476, 652, 79, 14, 1000, 56477, 1000000, 67576468, 230000000 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($">> {nums[i]}{DataHelper.SuffixOfNumberForAZ(nums[i])} ədəd.");
            }
        }
    }

}
