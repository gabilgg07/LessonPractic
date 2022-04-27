using System;
namespace Helper
{
    static public class DataHelper
    {
        public static DateTime[] NonWorkDaysOf2022()
        {
            return new DateTime[]
            {
                new DateTime(2022,3,20),
                new DateTime(2022,3,21),
                new DateTime(2022,3,22),
                new DateTime(2022,3,23),
                new DateTime(2022,3,24),
                new DateTime(2022,3,25),
                new DateTime(2022,5,2),
                new DateTime(2022,5,3),
                new DateTime(2022,5,9),
                new DateTime(2022,5,28),
                new DateTime(2022,5,30),
                new DateTime(2022,6,15),
                new DateTime(2022,6,26),
                new DateTime(2022,6,27),
                new DateTime(2022,7,9),
                new DateTime(2022,7,10),
                new DateTime(2022,7,11),
                new DateTime(2022,7,12),
                new DateTime(2022,11,8),
                new DateTime(2022,11,9),
                new DateTime(2022,12,31)
            };
        }

        /// <summary>
        /// Azərbaycan dilində rəqəm sonluğu gətirən metod.
        /// Culture-ni AZ etmək lazımdır.
        /// </summary>
        /// <param name="num">Şəkilçisini verəcək rəqəmi tələb edir.</param>
        /// <returns>Verilmiş rəqəmə uyğun string tipində şəkilçi qaytarır</returns>
        public static string SuffixOfNumberForAZ(int num)
        {
            if (num == 0
                || num % 10 == 6
                || num % 100 == 40
                || num % 100 == 60
                || num % 100 == 90
                )
            {
                return "-cı";
            }
            else if (num % 10 == 3
                || num % 10 == 4
                || (num % 100 == 0 && num / 100 % 10 != 0)
                )
            {
                return "-cü";
            }
            else if (num % 10 == 9
                || (num % 10 == 0 && (num / 10 % 10 == 1 || num / 10 % 10 == 3))
                || (num % 1000000 == 0 && num / 1000000 % 1000 != 0)
                )
            {
                return "-cu";
            }
            else
            {
                return "-ci";
            }
        }

        /// <summary>
        /// Azərbaycan dilində ahəng qanunu ilə rəqəmə uyğun sonluq (ı,i,u,ü) gətirən metod.
        /// Culture-ni AZ etmək lazımdır.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ForSuffixOfNumberForAZ(int num)
        {
            if (num == 0
                || num % 10 == 6
                || num % 100 == 40
                || num % 100 == 60
                || num % 100 == 90
                )
            {
                return "ı";
            }
            else if (num % 10 == 3
                || num % 10 == 4
                || (num % 100 == 0 && num / 100 % 10 != 0)
                )
            {
                return "ü";
            }
            else if (num % 10 == 9
                || (num % 10 == 0 && (num / 10 % 10 == 1 || num / 10 % 10 == 3))
                || (num % 1000000 == 0 && num / 1000000 % 1000 != 0)
                )
            {
                return "u";
            }
            else
            {
                return "i";
            }
        }

        public static string IntAZSuffix(int num)
        {
            if (num == 0
                || num % 10 == 6
                || num % 100 == 40
                || num % 100 == 60
                || num % 100 == 90
                )
            {
                return "ı";
            }
            else if (num % 10 == 3
                || num % 10 == 4
                || (num % 100 == 0 && num / 100 % 10 != 0)
                )
            {
                return "ü";
            }
            else if (num % 10 == 9
                || (num % 10 == 0 && (num / 10 % 10 == 1 || num / 10 % 10 == 3))
                || (num % 1000000 == 0 && num / 1000000 % 1000 != 0)
                )
            {
                return "u";
            }
            else
            {
                return "i";
            }
        }

        public static string DecimalAZSuffix(decimal num)
        {
            if (num * 10 % 10 != 0)
            {
                string numStr = num.ToString();
                int len = numStr.Length;

                if (numStr[^1] == '6' || numStr[^1] == '0')
                {
                    return "ı";
                }
                else if (numStr[^1] == '3' ||
                         numStr[^1] == '4')
                {
                    return "ü";
                }
                else if (numStr[^1] == '9')
                {
                    return "u";
                }
            }
            else
            {
                if (num == 0
                || num % 10 == 6
                || num % 100 == 40
                || num % 100 == 60
                || num % 100 == 90
                )
                {
                    return "ı";
                }
                else if (num % 10 == 3
                    || num % 10 == 4
                    || (num % 100 == 0 && num / 100 % 10 != 0)
                    )
                {
                    return "ü";
                }
                else if (num % 10 == 9
                    || (num % 10 == 0 && (num / 10 % 10 == 1 || num / 10 % 10 == 3))
                    || (num % 1000000 == 0 && num / 1000000 % 1000 != 0)
                    )
                {
                    return "u";
                }
            }

            return "i";

        }

        public static string DoubleAZSuffix(double num)
        {
            if (num * 10 % 10 != 0)
            {
                string numStr = num.ToString();
                int len = numStr.Length;

                if (numStr[^1] == '6' || numStr[^1] == '0')
                {
                    return "ı";
                }
                else if (numStr[^1] == '3' ||
                         numStr[^1] == '4')
                {
                    return "ü";
                }
                else if (numStr[^1] == '9')
                {
                    return "u";
                }
            }
            else
            {
                if (num == 0
                || num % 10 == 6
                || num % 100 == 40
                || num % 100 == 60
                || num % 100 == 90
                )
                {
                    return "ı";
                }
                else if (num % 10 == 3
                    || num % 10 == 4
                    || (num % 100 == 0 && num / 100 % 10 != 0)
                    )
                {
                    return "ü";
                }
                else if (num % 10 == 9
                    || (num % 10 == 0 && (num / 10 % 10 == 1 || num / 10 % 10 == 3))
                    || (num % 1000000 == 0 && num / 1000000 % 1000 != 0)
                    )
                {
                    return "u";
                }
            }

            return "i";

        }

        public static string DoubleAZSuffixStringWay(double num)
        {
            string numStr = num.ToString();
            int len = numStr.Length;
            bool hasNotDot = numStr.IndexOf('.') == -1;

            if (numStr[len - 1] == '6' ||
                (hasNotDot && len >= 2 && numStr[^1] == '0' &&
                (numStr[^2] == '4' || numStr[^2] == '6' || numStr[^2] == '9')))
            {
                return "ı";
            }
            else if (numStr[len - 1] == '3' ||
                numStr[^1] == '4' ||
                (hasNotDot && len >= 3 && numStr[^1] == '0' && numStr[^2] == '0' && numStr[^3] != '0'))
            {
                return "ü";
            }
            else if (numStr[^1] == '9')
            {
                return "u";
            }
            else if (numStr.IndexOf('.') == -1 && len >= 2)
            {
                string last2Letters = numStr.Substring(len - 2, 2);


                if (last2Letters == "40" || last2Letters == "60" || last2Letters == "90")
                {
                    return "ı";
                }
                else if (last2Letters == "10" || last2Letters == "30")
                {
                    return "u";
                }
                else if (len >= 3)
                {
                    string last3Letters = numStr.Substring(len - 3, 3);

                    if (last2Letters == "00" && numStr[^3] != '0')
                    {
                        return "ü";
                    }
                    else if (len >= 7)
                    {
                        string last6Letters = numStr.Substring(len - 6, 6);
                        char Letter7 = numStr[^7];
                        if (Letter7 != '0' && last6Letters == "000000")
                        {
                            return "u";
                        }
                    }
                }
            }
            return "i";
        }

        /// <summary>
        /// If difference Now and any date,
        /// Calculated difference from Now and return years.
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        //public static int YearsIfDiffFromNow(this TimeSpan ts)
        public static int YearsOfTimeSpan(this TimeSpan ts)
        {
            DateTime date = DateTime.Now - ts;

            int years = DateTime.Now.Year - date.Year;

            if (DateTime.Now.Month > date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day >= date.Day))
            {
                return years;
            }
            else
            {
                return years - 1;
            }
        }
    }
}
