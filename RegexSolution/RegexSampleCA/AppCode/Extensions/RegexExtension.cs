using System;
using System.Text.RegularExpressions;

namespace RegexSampleCA.AppCode.Extensions
{
    // Filenin adi RegexExtension olur,
    // Partial class-in adi Extention olur.
    static public partial class Extension
    {
        public const string emailInTextPattern = @"([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";
        public const string emailInTextPatternForParalleling = @"mailto:(?<email>([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?))";
        public const string emailPattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        static public bool IsEmail(this string value)
        {
            if (Regex.IsMatch(value, emailPattern))
                return true;

            return false;
        }
    }
}
