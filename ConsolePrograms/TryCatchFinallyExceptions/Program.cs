using System;
using System.IO;

namespace TryCatchFinallyExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                //double b = 10 / a; => DivideByZeroException error

                //throw new NotImplementedException(); 

                //throw new ArgumentNullException();

                //throw new ArgumentException();

                int[] arr = new int[] { 1, 2, 3, 4, 5 };

                //Console.WriteLine(arr[5]); => IndexOutOfRangeException error

                //string content = System.IO.File.ReadAllText("/Users/macbook/Desktop/Practice/test3.txt"); => FileNotFoundException

                //Console.WriteLine(content);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Log(ex);
                Console.WriteLine("Massivin uzunlugunu ashmisiniz");
            }
            catch (FileNotFoundException ex)
            {
                // Log(ex);
                Console.WriteLine("Fayl tapilmadi");
            }
            catch (DivideByZeroException ex)
            {
                // Log(ex);
                Console.WriteLine("0-a bolme xetasi");
            }
            catch (NotImplementedException ex)
            {
                // Log(ex);
                Console.WriteLine("Tamamlanmamis emeliyyat xetasi");
            }
            catch (ArgumentNullException ex)
            {
                // Log(ex);
                Console.WriteLine("Element bos olma xetasi");
            }
            catch (ArgumentException ex)
            {
                // Log(ex);
                Console.WriteLine("Elementle elaqedar xeta");
            }
            catch (Exception ex)
            {
                // save error with logger
                // Log(ex.ToString());
                Console.WriteLine("Zehmet olmasa biraz sonra yeniden yoxlayin");
            }
            finally
            {
                // is bitti, misal fayli bagla.
            }

            Console.ReadKey();
        }
    }
}
