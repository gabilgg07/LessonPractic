using System;
using System.Runtime.InteropServices;
using BankAccounting;
using BankAccounting.Exceptions;

namespace GreenBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Samir", "Esedov", "0000001", 1000);

            Card card = new Card("0001-0002-0003-0004", 2022, 5, 333, "1433");

            card.SetAccount(account);



            try
            {

                // card-in vaxti kecmis olarsa,
                // yeni ExpiredYear=2021 olarsa:
                // card.Debet(400); // => CardExpiredException

                card.Debet(400);

                Console.Write("card.Debet(400)->Balance: ");
                Console.WriteLine(card.GetBalance());

                // card-in creditMinusAccess-i true olanda:
                //card.Credit(600);

                //Console.Write("card.Credit(600)->Balance: ");
                //Console.WriteLine(card.GetBalance()); // -200

                // card-in creditMinusAccess-i false olanda:
                //card.Credit(600); => LimitOverflowException

                card.Debet(1400);

                Console.Write("card.Debet(1400)->Balance: ");
                Console.WriteLine(card.GetBalance());

                card.Debet(320);

                Console.Write("card.Debet(320)->Balance: ");
                Console.WriteLine(card.GetBalance());

                card.Credit(430);

                Console.Write("card.Credit(430)->Balance: ");
                Console.WriteLine(card.GetBalance());

                card.Credit(32);

                Console.Write("card.Credit(32)->Balance: ");
                Console.WriteLine(card.GetBalance());

                card.Credit(217);

                Console.Write("card.Credit(217)->Balance: ");
                Console.WriteLine(card.GetBalance());

                // card.Credit(356); // => DairlyLimitOverflowException

                Console.WriteLine(card);

            }
            catch (DairlyLimitOverflowException ex)
            {
                Console.WriteLine("Gunluk limiti asmisiniz");
            }
            catch (LimitOverflowException ex)
            {
                Console.WriteLine("Balansda kifayet qeder pul yoxdur");
            }
            catch (CardExpiredException ex)
            {
                Console.WriteLine("Kartiniz aktiv deyil");
            }

            Console.ReadKey();
        }
    }
}
