using System;
using BankAccounting;
using CustomExeptionType.Extensions;

namespace CustomExeptionType
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2 partial 1 class-da,
            // her partial-a mexsus methodlari 1 class uzerinden cagira bilirik.
            Extension.IsEmail();
            Extension.Log(new Exception());


            Account account = new Account("Samir", "Esedov", "0000001", 1000);

            Card card = new Card("0001-0002-0003-0004",2022,5,333,"1433");

            card.SetAccount(account);

            card.Debet(400);
            card.Debet(1400);
            card.Debet(320);

            Console.Write("Balance: ");
            Console.WriteLine(card.GetBalance());

            card.Credit(560);

            Console.Write("Balance: ");
            Console.WriteLine(card.GetBalance());

            card.Credit(400);

            Console.Write("Balance: ");
            Console.WriteLine(card.GetBalance());

            Console.ReadKey();
        }
    }
}