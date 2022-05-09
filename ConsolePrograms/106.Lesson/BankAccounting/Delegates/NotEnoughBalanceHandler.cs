using System;
using BankAccounting.EventArguments;

namespace BankAccounting.Delegates
{
    public delegate void NotEnoughBalanceHandler(object sender, NotEnoughBalanceArgs e);
}
