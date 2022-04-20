using System;
using System.Collections.Generic;
using BankAccounting.Exceptions;

namespace BankAccounting
{
    public class Account
    {
        //static Dictionary<string, int> transactions = new Dictionary<string, int>();
        KeyValuePair<DateTime, decimal> dailyCreditAmount;

        public Account(string name, string surname, string accountNumber, decimal dairlyLimit, bool creditMinusAccess = false)
        {
            this.Name = name;
            this.Surname = surname;
            this.AccountNumber = accountNumber;
            this.DailyLimit = dairlyLimit;
            this.CreditMinuseAccess = creditMinusAccess;
            dailyCreditAmount = new KeyValuePair<DateTime, decimal>(DateTime.Now, 0);
        }
        public bool CreditMinuseAccess { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal DailyLimit { get; set; }
        public decimal DailyTakedFromLimit { get; set; }


        #region Natamam kod

        //internal string Debet(decimal amount, Card card)
        //{
        //    Balance += amount;
        //    string transactionNo = Guid.NewGuid().ToString();
        //    transactions.Add(transactionNo, card.Id);
        //    // emeliyyatin tranzaksiya kodu
        //    return Guid.NewGuid().ToString();

        //}

        //internal string Credit(decimal amount, Card card)
        //{
        //    if (!CreditMinuseAccess && Balance-amount<0)
        //    {
        //        throw new Exception();
        //    }

        //    Balance -= amount;
        //    string transactionNo = Guid.NewGuid().ToString();
        //    transactions.Add(transactionNo,card.Id);
        //    // emeliyyatin tranzaksiya kodu
        //    return Guid.NewGuid().ToString();
        //}

        #endregion

        internal void Debet(decimal amount, Card card)
        {
            if (!card.IsActive)
            {
                //throw new Exception("Kart aktiv deyil!");
                throw new CardExpiredException();
            }

            Balance += amount;

        }

        internal void Credit(decimal amount, Card card)
        {
            if (!card.IsActive)
            {
                //throw new Exception("Kart aktiv deyil!");
                throw new CardExpiredException();
            }

            if (!CreditMinuseAccess && Balance - amount < 0)
            {
                //throw new Exception("Balansinizda kifayet qeder mebleg yoxdur!");
                throw new LimitOverflowException();
            }

            TimeSpan diff = DateTime.Now - dailyCreditAmount.Key;

            if (diff.Days < 1 && dailyCreditAmount.Value + amount > DailyLimit)
            {
                throw new DairlyLimitOverflowException("Gunluk limiti ashmisiniz!");
            }
            else if (diff.Days >= 1)
            {
                dailyCreditAmount = new KeyValuePair<DateTime, decimal>(DateTime.Now, 0);
            }


            Balance -= amount;
            dailyCreditAmount = new KeyValuePair<DateTime, decimal>(dailyCreditAmount.Key, dailyCreditAmount.Value + amount);
            DailyTakedFromLimit = dailyCreditAmount.Value;
        }
    }
}
