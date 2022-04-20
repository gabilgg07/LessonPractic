using System;
namespace BankAccounting.Exceptions
{
    public class LimitOverflowException : Exception
    {
        public LimitOverflowException()
        {
        }

        public LimitOverflowException(string message)
            :base(message)
        {
        }
    }
}
