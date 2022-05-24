using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Helper;

namespace TaskParallelLibraryCA
{
    class Program
    {
        // Yaddas tutum olcu vahidlerin adlari:
        private static string[] Parts = { "Byte",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB",
            "BB"
        };

        /// <summary>
        /// Convert from Byte to Correct Part
        /// 1 Kilobyte   (KB) = 1024 Byte =1024^1  Byte
        /// 1 Megabyte   (MB) = 1024 KB   =1024^2  Byte
        /// 1 Gigabyte   (GB) = 1024 MB   =1024^3  Byte
        /// 1 Terabyte   (TB) = 1024 GB   =1024^4  Byte
        /// 1 Petabyte   (PB) = 1024 TB   =1024^5  Byte
        /// 1 Exabyte    (EB) = 1024 PB   =1024^6  Byte
        /// 1 Zettabyte  (ZB) = 1024 EB   =1024^7  Byte
        /// 1 Yottabyte  (YB) = 1024 ZB   =1024^8  Byte
        /// 1 Brontobyte (BB) = 1024 YB   =1024^9  Byte
        /// 1 Geopbyte        = 1024 BB   =1024^10 Byte
        /// </summary>
        /// <param name="octet">Input Byte Value</param>
        /// <returns>Return Correct Part</returns>
        static string GetFixed(double value)
        {
            int index = 0;

            while (Convert.ToInt64(value / 1024) > 0)
            {
                index++;
                value /= 1024;
            }


            return $"{value:0.0#} {Parts[index]}";
        }

        private static void Print1()
        {
            for (int i = 0; i < Console.WindowWidth * 5; i++)
            {
                Console.Write("1");
            }
        }

        static void Main(string[] args)
        {
            // TPL - Task Parallel Library
            ConsoleHelper.SetDefaults();
            ConsoleHelper.Header("TPL - Task Parallel Library", '>','<', ConsoleColor.Gray, ConsoleColor.DarkYellow);

            Task task0 = new Task(() =>
            {
                for (int i = 0; i < Console.WindowWidth * 5; i++)
                {
                    Console.Write("0");
                }
            });

            Task task1 = new Task(Print1);

            //TasksStartParallel(task0, task1);

            //TaskRunMethod();

            //TaskContinueWith(task0, task1);

            //TaskWaitMethod(task0, task1);

            //TaskWaitAllMethod(task0, task1);

            //TaskWhenAllMethod(task0, task1);

            //TaskWhenAllMethodWithExceptionInTask(task0, task1);

            //GetDrivesNameAndTotalSizes();

            //FindSlnFilesIsNotAccessibility();

            //TaskWaitAnyAndWhenAny(task0, task1);

            //TaskDelay(task0, task1);

            Console.ReadKey();
        }

        private static void TaskDelay(Task task0, Task task1)
        {

            task0.Start();

            Task.Delay(TimeSpan.FromSeconds(5)).Wait();

            task1.Start();

        }

        private static void TaskWaitAnyAndWhenAny(Task task0, Task task1)
        {
            task0.Start();
            task1.Start();

            // .WaitAny() her hansi biri bitdikde dayanir,
            // novbeti kodlar oxunur.
            int count = Task.WaitAny(task0, task1);

            Console.WriteLine($"Count: {count}");

            // .WhenAny() de eynile,her hansi biri bitdikde dayanir,
            // novbeti kodlar oxunur ve yene Task qaytarir. 
            //Task.WhenAny(task0, task1).Wait();
        }

        private static void FindSlnFilesIsNotAccessibility()
        {
            // drive diskleri getir
            string[] driveNames = DriveInfo.GetDrives()
                // hansiki, .IsReady-si true olanlari
                .Where(d => d.IsReady == true)
                // onlarin da adlarini qaytar
                .Select(d => d.Name)
                // qaytardigin IEnumerable-ni de massive cevirib qaytar.
                .ToArray();

            // tapdigin adlarin sayi qeder Task yarat.
            Task[] tasks = new Task[driveNames.Length];

            for (int i = 0; i < tasks.Length; i++)
            {

                string diskName = driveNames[i];

                tasks[i] = Task.Run(() =>
                {


                    // file-leri getir,
                    // bu pathdaki,
                    // butun .sln sonlugu ile bitenleri,
                    // butun ic-ice qovluqlarin hamisinda axtar          
                    string[] files = Directory.GetFiles(diskName, "*.sln", SearchOption.AllDirectories);

                    // ancaq ustde olan qovluqlarda axtar demekdir
                    //Directory.GetFiles(driveName, "*.sln", SearchOption.TopDirectoryOnly);

                    Console.WriteLine($"Disk: {diskName}, found: {files.Length} /*.sln");
                });
            }

            Stopwatch sw = new Stopwatch();

            sw.Start();

            Task.WhenAll(tasks).ContinueWith(r =>
            {
                sw.Stop();

                if (r.IsCompletedSuccessfully)
                {
                    Console.WriteLine($"EllapsedTime : {sw.ElapsedMilliseconds} ms");
                }
                else
                {
                    Console.WriteLine(r.Exception);
                }
            }).Wait();

        }

        private static void GetDrivesNameAndTotalSizes()
        {
            // DriveInfo drive disk nezerde tutulur,
            // DriveInfo.GetDrives() method-u butun drive diskleri getirir.
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // drive.Name adidir,
                // drive.TotalSize umumi hevmidir.
                Console.WriteLine($"{drive.Name} - {GetFixed(drive.TotalSize)}");
            }
        }

        private static void TaskWhenAllMethodWithExceptionInTask(Task task0,Task task1)
        {
            ConsoleHelper.Header("Task WhenAll Method With Exception");


            Task task2 = new Task(() =>
            {
                for (int i = 0; i < Console.WindowWidth * 5; i++)
                {
                    if (i == (Console.WindowWidth * 5 / 2))
                    {
                        throw new NotFiniteNumberException();
                    }
                    else
                    {
                        Console.Write("2");
                    }
                }
            });


            task0.Start();
            task1.Start();
            task2.Start();

            // .WhenAll(Task[] tasks) butun gosterilmis Task-lar
            // bitdikden sonra .ContinueWith() ile IsCompletedSuccessfully qaytarir
            // ve .Wait()-le neticeni gosterir.
            Task.WhenAll(task0, task1, task2)
                .ContinueWith(r =>
                {
                    if (r.IsCompletedSuccessfully)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        ConsoleHelper.Header("Good Bye!", '.');
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\nHansısa task-da xəta baş verdi!\n");
                        Console.WriteLine($"Error: {r.Exception}\n");
                    }
                }
                )

                // Wait() neticeni gostermesi ucundu
                .Wait();
        }

        private static void TaskWhenAllMethod(Task task0, Task task1)
        {
            ConsoleHelper.Header("Task WhenAll");

            task0.Start();
            task1.Start();

            // .WhenAll(Task[] tasks) butun gonderilmis Task-lar
            // bitdikden sonra method bize Task qaytarir,
            // o Task-i .ContinueWith() ile ardinca icra olunacaq kodu yazib,
            // misal IsCompletedSuccessfully qaytarmasi kimi, yazib,
            // .Wait()-le neticeni gosteririk.
            Task.WhenAll(task0, task1)
                .ContinueWith(
                r =>
                {
                    if (r.IsCompletedSuccessfully)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        ConsoleHelper.Header("Good Bye!", '.');
                    }
                    else
                    {
                        Console.WriteLine("Hansısa task-da xəta baş verdi!");
                    }
                }
                )
                // .ContinueWith() de bir task oldugu ucun,
                // butun tasklari netice ucun .Wait() etmeliyik.
                // Wait() neticeni gosterib sonra davam etmesi ucundu
                .Wait();
        }

        private static void TaskWaitAllMethod(Task task0, Task task1)
        {
            ConsoleHelper.Header("Task AllWait");

            // .WaitAll(Task[] tasks) verilmis (params kimi oturulmus) Task
            // array-indekilerin hamisini isinin icra olunub bitmesini gozledir
            // sonra novbeti kodlari oxumaga davam edir.

            task0.Start();
            task1.Start();
            Task.WaitAll(task0, task1);
            Console.WriteLine("Task.WaitAll()");

        }

        private static void TaskWaitMethod(Task task0, Task task1)
        {
            ConsoleHelper.Header("Task Wait");

            // task1.Wait() methodu task1 taskinin bitmesini gozledir.
            // Bitdikden sonra task0 icrasi baslayir.

            task1.Start();
            task1.Wait();
            task0.Start();
        }

        private static void TaskContinueWith(Task task0, Task task1)
        {
            ConsoleHelper.Header("Task ContinueWith");

            // task0 bitdikden sonra Task1-i islederek davam edir:
            task0.ContinueWith(r =>
            {
                task1.Start();
            });

            task0.Start();
        }

        private static void TaskRunMethod()
        {

            ConsoleHelper.Header("Task Run methodu");

            // asagidaki kimi yazildiqda .Start() yazmadan bir basa start edir:

            Task task0 = Task.Run(() =>
            {
                for (int i = 0; i < Console.WindowWidth * 5; i++)
                {
                    Console.WriteLine("0");
                }
            });
        }

        private static void TasksStartParallel(Task task0, Task task1)
        {

            ConsoleHelper.Header("Taskları paralel işe salma");
            // Tasklari parallel ise salir:

            task0.Start();
            task1.Start();

        }

    }
}
