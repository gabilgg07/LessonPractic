using System;
namespace BankAccounting.EventArguments
{
    public class NotEnoughBalanceArgs
    {
        public decimal CurrentBalance { get; set; }
        public decimal Amount { get; set; }
        public string Message { get; set; }
    }
}
