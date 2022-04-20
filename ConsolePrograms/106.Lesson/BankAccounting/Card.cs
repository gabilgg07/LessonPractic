using System;
namespace BankAccounting
{
    public class Card
    {
        static int counter = 0;
        public Card()
        {
            Id = ++counter;
        }
        public Card(string cardNumber, int year, int month, ushort cvc, string pin)
            : this()
        {
            this.CardNumber = cardNumber;
            this.ExpiredYear = year;
            this.ExpiredMonth = month;
            this.Cvc = cvc;
            this.Pin = pin;
        }

        public int Id { get; private set; }
        public string CardNumber { get; set; }
        public int ExpiredYear { get; set; }
        public int ExpiredMonth { get; set; }
        public ushort Cvc { get; set; }
        public string Pin { get; set; }
        public bool IsActive
        {
            get
            {
                DateTime today = DateTime.Today;
                if (today.Year > ExpiredYear || today.Year == ExpiredYear && today.Month > ExpiredMonth)
                {
                    return false;
                }

                return true;
            }
        }

        public Account Account { get; private set; }


        public void SetAccount(Account account)
        {
            this.Account = account;
        }

        public decimal GetBalance()
        {
                return Account.Balance;
        }

        public void Debet(decimal amount)
        {
            Account.Debet(amount, this);
        }

        public void Credit(decimal amount)
        {
            Account.Credit(amount, this);
        }

        public override string ToString()
        {
            return $"\nFullName: {Account.Name} {Account.Surname}\n" +
                $"Dairly Limit: {Account.DailyLimit}\n" +
                $"Taked from Limit: {Account.DailyTakedFromLimit}\n" +
                $"The rest of limit: {Account.DailyLimit-Account.DailyTakedFromLimit}\n" +
                $"Balance: {GetBalance()}\n";
        }
    }
}
