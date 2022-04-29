using System;
using BankAccounting.EventArguments;

namespace BankAccounting.Delegates
{
    public delegate void CardExpiredHandler(object sender, CardExpiredArgs e);
}
