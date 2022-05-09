using System;
namespace BankAccounting.EventArguments
{
    public class DairlyLimitOverflowArgs : EventArgs
    {
        public decimal DLimit { get; set; }
        public decimal TakedFromLimit { get; set; }
        public decimal Amount { get; set; }
        public string Message { get; set; }
    }
}
