using System;
using BankAccounting.EventArguments;

namespace BankAccounting.Delegates
{
    public delegate void DairlyLimitOverflovHandler(object sender, DairlyLimitOverflowArgs e);
}
