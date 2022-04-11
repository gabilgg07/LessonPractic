using System;
using System.Globalization;

namespace AcademyTask.ConsoleApp2.AppCode.Extensions
{
    public static class DateTimeExtension
    {
       public static DateTime? ToDate(this string value, string format)
        {
            if (DateTime.TryParseExact(value, format, null, DateTimeStyles.None,
                out DateTime date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }
    }
}
