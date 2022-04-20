using System;
namespace BankAccounting.Exceptions
{
    public class DairlyLimitOverflowException : Exception
    {
        public DairlyLimitOverflowException()
        {
        }

        public DairlyLimitOverflowException(string message)
            : base(message)
        {
        }
    }
}
