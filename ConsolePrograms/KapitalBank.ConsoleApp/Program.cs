using System;
using BankAccounting;
using Helper;

namespace KapitalBank.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.SetDefaults();

            Account account = new Account("Əli", "Əhədli", "0000007", 500);
            Card card = new Card("0001-0002-0003-0004",2022,10,654,"0000");

            account.OnCardExpired += Account_OnCardExpired;
            account.OnDairlyLimitOverflow += Account_OnDairlyLimitOverflow;
            account.OnNotEnoughBalance += Account_OnNotEnoughBalance;

            card.SetAccount(account);

            card.Debet(340);

            card.Credit(600);

            Console.WriteLine(card);
            card.Credit(100);

            Console.WriteLine(card);
            card.Credit(300);

            Console.WriteLine(card);
            card.Credit(100);
            card.Credit(100);

            Console.WriteLine(card);

            Console.ReadKey();
        }

        private static void Account_OnNotEnoughBalance(Account account, Card card, string msg, decimal amount)
        {
            Console.WriteLine($"Hörmətli {account.Name} {account.Surname}, \n" +
               $"Balansınızdakı məbləğ kifayət qədər deyil. \n" +
               $"Balansınız: {account.Balance}");
        }

        private static void Account_OnDairlyLimitOverflow(Account account, Card card, string msg, decimal amount)
        {
            Console.WriteLine($"Hörmətli {account.Name} {account.Surname}, \n" +
                $"Sizin günlük limitiniz {account.DailyLimit}-d{DataHelper.DecimalAZSuffix(account.DailyLimit)}r, \n" +
                $"Artıq {account.DailyTakedFromLimit} qədərini istifadə etmisiniz.\n" +
                $"{amount} miqdarında çıxara bilməzsiniz.");
        }

        private static void Account_OnCardExpired(Account account, Card card, string msg)
        {
            Console.WriteLine($"Hormetli {account.Name} {account.Surname}, \n" +
                $"Kartinizin istifade muddeti {card.ExpiredMonth}/{card.ExpiredYear} tarixinde bitib");
        } 
    }
}
