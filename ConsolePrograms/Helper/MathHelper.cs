using System;
namespace Helper
{
    static public class MathHelper
    {
        static public int SumNumDigits(int num)
        {
            int sumDigits = 0;

            while (num>0)
            {
                sumDigits += num % 10;
                num /= 10;
            }

            return sumDigits;
        }
    }
}
