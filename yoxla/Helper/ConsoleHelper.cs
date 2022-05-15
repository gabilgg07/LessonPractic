using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Helper
{
    static public class ConsoleHelper
    {
        static public void SetDefaults()
        {
            CultureInfo ci = new CultureInfo("az");
            ci.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            ci.DateTimeFormat.LongDatePattern = "dd.MM.yyyy";
            ci.DateTimeFormat.ShortTimePattern = "HH:mm";
            ci.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            ci.DateTimeFormat.FullDateTimePattern = "dd.MM.yyyy HH:mm:ss";
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = ci;


            Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;
        }
    }
}
