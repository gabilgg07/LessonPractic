using System;
using BankAccounting;
using BankAccounting.EventArguments;
using BankAccounting.Exceptions;
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
            account.OnDairlyLimitOverflow += Account_OnDairlyLimitOverflow1;
            account.OnNotEnoughBalance += Account_OnNotEnoughBalance1;

            card.SetAccount(account);

            card.Debet(340);

            // -> NotEnoughBalance
            card.Credit(600);


            Console.WriteLine("\ncard.Credit(600) => after NotEnoughBalance =>");
            Console.WriteLine(card);

            card.Credit(100);
            Console.WriteLine("\ncard.Credit(100) => ");
            Console.WriteLine(card);

            card.Debet(500);
            Console.WriteLine("\ncard.Debet(500) => ");
            Console.WriteLine(card);

            // -> DairlyLimitOverflow
            card.Credit(450);


            Console.WriteLine("\ncard.Credit(450) => after DairlyLimitOverflow => ");
            Console.WriteLine(card);

            card.Credit(100);
            card.Credit(100);
            Console.WriteLine("\n(1) - card.Debet(100)\n(2) - card.Debet(100) => ");
            Console.WriteLine(card);

            Console.ReadKey();
        }

        private static void Account_OnNotEnoughBalance1(object sender, NotEnoughBalanceArgs e)
        {
            Card card = sender as Card;

            if (card == null)
            {
                throw new LimitOverflowException();
            }
            Account account = card.Account;

            Console.WriteLine($"Hormetli {account.Name} {account.Surname}, \n" +
                $"Balansınızda {e.Amount} azn qədər məbləğ yoxdur. \n" +
                $"Balansınız: {account.Balance} azn-dir");

        }

        private static void Account_OnDairlyLimitOverflow1(object sender, DairlyLimitOverflowArgs e)
        {
            Card card = sender as Card;

            if (card == null)
            {
                throw new DairlyLimitOverflowException();
            }
            Account account = card.Account;

            Console.WriteLine($"Hörmətli {account.Name} {account.Surname}, \n" +
               $"Sizin günlük limitiniz {e.DLimit} azn-dir, \n" +
               $"Artıq {e.TakedFromLimit} azn miqdarında istifadə etmisiniz.\n" +
               $"{e.Amount} azn miqdarında çıxara bilməzsiniz.\n" +
               $"Maksimum {e.DLimit - e.TakedFromLimit} azn çıxara bilərsiniz.");
        }

        private static void Account_OnCardExpired(object sender, CardExpiredArgs e)
        {
            Card card = sender as Card;

            if (card == null)
            {
                throw new CardExpiredException();
            }
            Account account = card.Account;

            Console.WriteLine($"Hormetli {account.Name} {account.Surname}, \n" +
                $"Kartinizin istifade muddeti {e.ExpiredMonth:00}/{(e.ExpiredYear%100):00} tarixinde bitib");
        }

        //private static void Account_OnNotEnoughBalance(Account account, Card card, string msg, decimal amount)
        //{
        //    Console.WriteLine($"Hörmətli {account.Name} {account.Surname}, \n" +
        //       $"Balansınızdakı məbləğ kifayət qədər deyil. \n" +
        //       $"Balansınız: {account.Balance}");
        //}

        //private static void Account_OnDairlyLimitOverflow(Account account, Card card, string msg, decimal amount)
        //{
        //    Console.WriteLine($"Hörmətli {account.Name} {account.Surname}, \n" +
        //        $"Sizin günlük limitiniz {account.DailyLimit}-d{DataHelper.DecimalAZSuffix(account.DailyLimit)}r, \n" +
        //        $"Artıq {account.DailyTakedFromLimit} qədərini istifadə etmisiniz.\n" +
        //        $"{amount} miqdarında çıxara bilməzsiniz.");
        //}
    }
}
