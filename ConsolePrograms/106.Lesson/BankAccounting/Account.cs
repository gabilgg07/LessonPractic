using System;
using System.Collections.Generic;
using BankAccounting.Delegates;
using BankAccounting.EventArguments;
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

        public event CardExpiredHandler OnCardExpired;
        public event DairlyLimitOverflovHandler OnDairlyLimitOverflow;
        public event NotEnoughBalanceHandler OnNotEnoughBalance;


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
            //if (!card.IsActive)
            //{
            //    //throw new Exception("Kart aktiv deyil!");
            //    throw new CardExpiredException();
            //}

            if (!card.IsActive)
            {
                var arg = new CardExpiredArgs()
                {
                    ExpiredYear = card.ExpiredYear,
                    ExpiredMonth = card.ExpiredMonth,
                    Message = "Kart aktiv deyil."
                };
                //throw new Exception("Kart aktiv deyil!");
                //throw new CardExpiredException();
                OnCardExpired?.Invoke(card, arg);
                return;
            }

            Balance += amount;

        }

        internal void Credit(decimal amount, Card card)
        {
            if (!card.IsActive)
            {
                var args = new CardExpiredArgs()
                {
                    ExpiredYear = card.ExpiredYear,
                    ExpiredMonth = card.ExpiredMonth,
                    Message = "Kart aktiv deyil."
                };
                //throw new Exception("Kart aktiv deyil!");
                //throw new CardExpiredException();
                OnCardExpired?.Invoke(card, args);
                return;
            }

            if (!CreditMinuseAccess && Balance - amount < 0)
            {
                //throw new Exception("Balansinizda kifayet qeder mebleg yoxdur!");
                //throw new LimitOverflowException();

                var args = new NotEnoughBalanceArgs()
                {
                    CurrentBalance = Balance,
                    Amount = amount,
                    Message = "Balansinizda kifayet qeder mebleg yoxdur"
                };

                OnNotEnoughBalance?.Invoke(card, args);
                return;
            }

            TimeSpan diff = DateTime.Now - dailyCreditAmount.Key;

            if (diff.Days < 1 && dailyCreditAmount.Value + amount > DailyLimit)
            {
                var args = new DairlyLimitOverflowArgs()
                {
                    DLimit = DailyLimit,
                    TakedFromLimit = DailyTakedFromLimit,
                    Amount = amount,
                    Message = "Gunluk limiti ashmisiniz"

                };

                //throw new DairlyLimitOverflowException("Gunluk limiti ashmisiniz!");
                OnDairlyLimitOverflow?.Invoke(card, args);
                return;
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
