using System;
namespace BankAccounting.Exceptions
{
    public class CardExpiredException:Exception
    {
        public CardExpiredException()
        {
        }

        public CardExpiredException(string message)
            :base(message)
        {
        }
    }
}
