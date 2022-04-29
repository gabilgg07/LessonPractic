using System;
namespace BankAccounting.EventArguments
{
    public class CardExpiredArgs : EventArgs 
    {
        public int ExpiredYear { get; set; }
        public int ExpiredMonth { get; set; }
        public string Message { get; set; }
    }
}
