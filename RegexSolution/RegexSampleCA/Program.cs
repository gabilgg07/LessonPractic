using System;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using RegexSampleCA.AppCode.Extensions;
using System.Web;
using System.Linq;

namespace RegexSampleCA
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegexTesting();

            // -----------------------------------------------------------------

            //RegexIgnoreCase();

            // -----------------------------------------------------------------

            //RegexMultiline();

            // -----------------------------------------------------------------

            //RegexHasNumber();

            // -----------------------------------------------------------------

            //RegexIsNumber();

            // -----------------------------------------------------------------

            //RegexIsPhone();

            // -----------------------------------------------------------------

            //RegexGetPhoneGroups();

            // -----------------------------------------------------------------

            //RegexGiveNameForGrpuos();

            // -----------------------------------------------------------------

            RegexMatchesMethod();

            Console.ReadKey();
        }

        private static void RegexMatchesMethod()
        {
            string fileName = "p511-20210227.txt";

            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            string path = Path.Combine(directory.ToString(), AppDomain.CurrentDomain.FriendlyName, fileName);


            string content = File.ReadAllText(path);

            Console.WriteLine(content);

            MatchCollection emails = Regex.Matches(content, Extension.emailInTextPattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }

        private static void RegexGiveNameForGrpuos()
        {
            string phonePattern = @"^(?<countryCode>\+994|0)(?<operatorCode>10|50|51|55|70|77|99)-?(?<phoneNumber>\d{3}-?\d{2}-?\d{2})$";

            Console.Write("2-ci Nomrenizi qeyd edin: ");

            string phone = Console.ReadLine();

            // Regular exprettion-un asagidaki methodu var ki,
            // eger input pattern-e uygundursa, pattern-de olan ()-ile ayrilmislari
            // group-lar seklinde bize vere bilir.
            Match matched = Regex.Match(phone, phonePattern);


            Console.WriteLine($">>{phone}<< ucun >>{phonePattern}<< patterni yoxlanilir: ");
            if (matched.Success)
            {
                //Console.WriteLine($"GroupAll: {matched.Groups[0]}");
                Console.WriteLine("----------------------");
                Console.WriteLine($"Country Code: {matched.Groups["countryCode"].Value}");
                Console.WriteLine($"Operaator Code: {matched.Groups["operatorCode"].Value}");
                Console.WriteLine($"Phone Number: {matched.Groups["phoneNumber"].Value}");
            }
            else
                Console.WriteLine($"{phone}, telefon nomresi deyil!");
        }

        private static void RegexGetPhoneGroups()
        {
            string phonePattern = @"^(\+994|0)(10|50|51|55|70|77|99)-?(\d{3}-?\d{2}-?\d{2})$";

            Console.Write("2-ci Nomrenizi qeyd edin: ");

            string phone = Console.ReadLine();

            // Regular exprettion-un asagidaki methodu var ki,
            // eger input pattern-e uygundursa, pattern-de olan ()-ile ayrilmislari
            // group-lar seklinde bize vere bilir.
            Match matched = Regex.Match(phone, phonePattern);


            Console.WriteLine($">>{phone}<< ucun >>{phonePattern}<< patterni yoxlanilir: ");
            if (matched.Success)
            {
                Console.WriteLine($"GroupAll: {matched.Groups[0]}");
                Console.WriteLine("----------------------");
                Console.WriteLine($"Group1: {matched.Groups[1]}");
                Console.WriteLine($"Group2: {matched.Groups[2]}");
                Console.WriteLine($"Group3: {matched.Groups[3]}");
            }
            else
                Console.WriteLine($"{phone}, telefon nomresi deyil!");
        }

        private static void RegexIsPhone()
        {
            string phonePattern = @"^(\+994|0)(10|50|51|55|70|77|99)-?\d{3}-?\d{2}-?\d{2}$";

            Console.Write("1-ci Nomrenizi qeyd edin: ");

            string phone = Console.ReadLine();

            bool isPhone = Regex.IsMatch(phone, phonePattern);


            Console.WriteLine($">>{phone}<< ucun >>{phonePattern}<< patterni yoxlanilir: ");
            if (isPhone)
            {
                Console.WriteLine($"{phone}, telefon nomresidir.");
            }
            else
                Console.WriteLine($"{phone}, telefon nomresi deyil!");
        }

        private static void RegexIsNumber()
        {
            // Yalnizca lazim olandan ibaret oldugunu tapmaq ucun
            // ^ baslama ve $ bitme isaresinden istifade edilir.

            Console.Write("Eded daxil edin: ");

            string num = Console.ReadLine();

            bool isNumber = Regex.IsMatch(num, @"^\d+$");

            Console.WriteLine($">>{num}<< ucun >>{@"^\d+$"}<< patterni yoxlanilir: ");
            if (isNumber)
            {
                Console.WriteLine($"{num}, ededdir");
            }
            else
                Console.WriteLine($"{num}, eded deyil!");
        }

        private static void RegexHasNumber()
        {
            Console.Write("Eded daxil edin: ");

            string num = Console.ReadLine();

            // eded olub olmadigini yoxlayir,
            // \ isaresini qebul etmesi ucun stringin qarsisina @ isaresi qoyulur.
            bool isNumber = Regex.IsMatch(num, @"\d");

            Console.WriteLine($">>{num}<< ucun >>{@"\d"}<< patterni yoxlanilir: ");
            if (isNumber)
            {
                Console.WriteLine($"{num}, daxilinde reqem var");
            }
            else
                Console.WriteLine($"{num}, daxilinde reqem yoxdur!");

            // yuxaridaa yazilanlarda text icerisinde verilmis paterine
            // uygun her hansi bir hisse taparsa true qaytarir.
        }

        private static void RegexMultiline()
        {
            Console.Write("Text daxil edin: ");

            string text = Console.ReadLine();
            string pattern = "(zoo)?park";
            // Elave olaraq Multiline yoxlanmasi ucun de RegexOptions.Multiline istifade edilir.
            // burada | her iki parametri qebul etdiyini gosterir.

            bool isValid = Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);

            Console.WriteLine($">>{text}<< ucun >>{pattern}<< patterni yoxlanilir: ");
            if (isValid)
            {
                Console.WriteLine($"{text}, okeydir");
            }
            else
                Console.WriteLine($"{text}, uygun deyil!");
        }

        private static void RegexIgnoreCase()
        {
            Console.Write("Text daxil edin: ");

            string text = Console.ReadLine();
            string pattern = "(zoo)?park";

            // Case sensetive-ni baglamaq ucun elave olaraq
            // RegexOptions.IgnoreCase parametrinden istifade edilir.
            bool isValid = Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine($">>{text}<< ucun >>{pattern}<< patterni yoxlanilir: ");
            if (isValid)
            {
                Console.WriteLine($"{text}, okeydir");
            }
            else
                Console.WriteLine($"{text}, uygun deyil!");
        }

        private static void RegexTesting()
        {
            string text = "Park";

            // pattern -> shablon, model, ornek demekdir.
            string pattern = "(zoo)?Park";

            // c#-da Regex yoxlamaq ucun asagidaki kimi yazilir:
            bool isValid = Regex.IsMatch(text, pattern);

            Console.WriteLine($">>{text}<< ucun >>{pattern}<< patterni yoxlanilir: ");
            if (isValid)
            {
                Console.WriteLine($"{text}, okeydir");
            }
            else
                Console.WriteLine($"{text}, uygun deyil!");
        }
    }
}
