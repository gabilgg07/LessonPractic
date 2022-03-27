using System;
using Helper;

namespace CodeOnCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.SetDefaults();

            DateTime dtStart = new DateTime(2022, 3, 13);
            DateTime dtEnd = new DateTime(2022, 12, 31);
            DateTime[] nonWorkDaysOf2022 = DataHelper.NonWorkDaysOf2022();

            while (dtStart.Date <= dtEnd.Date)
            {
                if (dtStart.DayOfWeek==DayOfWeek.Saturday|| dtStart.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (Array.IndexOf(nonWorkDaysOf2022, dtStart) != -1)
                        Console.WriteLine(dtStart.ToString("yy.MM.dd, ddd") + " (qeyri is gunu)");
                    else
                        Console.WriteLine(dtStart.ToString("yy.MM.dd, ddd"));
                }
                //Console.WriteLine(dtStart.ToLongDateString());

                dtStart = dtStart.AddDays(1);
            }
        }
    }
}
