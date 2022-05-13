using System;
using System.Net;
using System.Net.Mail;

namespace BD_Alert_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime today = DateTime.Today;
            //int todayMonth = today.Month;
            //int todayDay = today.Day;
            //AskDateForFindBD();


            // Email gondermek.
            // Getmirse google acountun basqa program istifadesini dayandirib demekdir.
            //SendEmailWhoHasBD("gabil.gurbanov.gadir@gmail.com","Ad gunun mubarek)");

        }

        private static void SendEmailWhoHasBD(string toEmail, string messageText)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("aaliyeva0791@gmail.com", "Aliyev@0791");
            client.EnableSsl = true;

            MailMessage message = new MailMessage("aaliyeva0791@gmail.com", toEmail);
            message.Subject = "Happy Birthday";
            message.Body = messageText;

            client.Send(message);
        }

        private static void AskDateForFindBD()
        {
            DateTime now;
        lblAgain:
        lblChoose:
            Console.WriteLine("===========================================");
            Console.Write(">> n herfi secseniz indiki vaxti secirsiz,\n" +
                ">> e herfi secseniz, tarixi ozunuz daxil edirsiniz. n/e: ");
            string choose = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            switch (choose.Trim())
            {
                case "n":
                    now = DateTime.Now;
                    break;
                case "e":
                lblNowTimeFormat:
                    Console.Write("Il/ay/gun formatinda tarix daxil edin: ");
                    string nowStr = Console.ReadLine();
                    Console.WriteLine("------------------------------------");
                    if (!DateTime.TryParse(nowStr, out now))
                    {
                        Console.WriteLine($"Daxil etdiyiniz {nowStr} Il/ay/gun formatina uygun deyil!");
                        Console.WriteLine("------------------------------------");
                        goto lblNowTimeFormat;
                    }
                    Console.WriteLine(now);
                    Console.WriteLine("========================");
                    break;
                default:
                    Console.WriteLine("Asagidaki herflerden birini secmelisiniz.");
                    goto lblChoose;
            }

            DateTime personBD;

        lblBD:
            Console.WriteLine("===========================================");
            Console.WriteLine("Dogum tarixini daxil edin, ve ya hazir olani secin: ");
            Console.Write(">> d herfi secseniz hazir olani secirsiz,\n" +
                ">> e herfi secseniz, tarixi ozunuz daxil edirsiniz. d/e: ");
            string bd = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            switch (bd.Trim())
            {
                case "d":
                    personBD = new DateTime(1991, 7, 7);
                    break;
                case "e":
                lblBDTimeFormat:
                    Console.Write("Il/ay/gun formatinda tarix daxil edin: ");
                    string bdStr = Console.ReadLine();
                    Console.WriteLine("------------------------------------");
                    if (!DateTime.TryParse(bdStr, out personBD))
                    {
                        Console.WriteLine($"Daxil etdiyiniz {bdStr} Il/ay/gun formatina uygun deyil!");
                        Console.WriteLine("------------------------------------");
                        goto lblBDTimeFormat;
                    }
                    Console.WriteLine(personBD);
                    Console.WriteLine("========================");
                    break;
                default:
                    Console.WriteLine("Asagidaki herflerden birini secmelisiniz.");
                    goto lblBD;
            }

            if (now.Year < personBD.Year)
            {
                Console.WriteLine("Dogum ili duzgun qeyd edilmeyib!");
                goto lblBD;
            }

            FindWhenBD(now, personBD);

            Console.WriteLine("================================");
            Console.Write("Yeniden sorgu gondermek ucun y secin: ");
            string again = Console.ReadLine();
            if (again.Trim().Trim() == "y")
            {
                goto lblAgain;
            }
        }

        public static void FindWhenBD(DateTime now, DateTime personBD)
        {
            int diffMonth;
            int diffDay;

            if (now.Month == personBD.Month)
            {
                if (now.Day == personBD.Day)
                    Console.WriteLine("Bugun dogum gunudur");
                else if (now.Day < personBD.Day)
                {
                    diffDay = personBD.Day - now.Day;
                    Console.WriteLine($"Dogum gunune {diffDay} gun qalib.");
                }
                else {
                    diffDay = now.Day - personBD.Day;
                    Console.WriteLine($"Dogum gununden {diffDay} gun kecib.");
                }
                        
            }
            else if (now.Month < personBD.Month)
            {

                diffMonth = personBD.Month - now.Month;
                if (now.Day < personBD.Day)
                {
                    diffDay = personBD.Day - now.Day;
                    Console.WriteLine($"Dogum gunune {diffMonth} ay, {diffDay} gun qalib.");

                }
                else if (now.Day > personBD.Day)
                {
                    DateTime pre = new DateTime(now.Year, now.Month, 1);
                    DateTime post = new DateTime(now.Month + 1 < 13 ? now.Year : now.Year + 1, now.Month + 1 < 13 ? now.Month + 1 : 1, 1);
                    TimeSpan nowMonthTotalDays = post - pre;
                    diffMonth--;
                    diffDay = (int)nowMonthTotalDays.TotalDays - now.Day + personBD.Day;
                    Console.WriteLine($"Dogum gunune {(diffMonth > 0 ? diffMonth + " ay, " : "")}{diffDay} gun qalib.");
                }
                else
                    Console.WriteLine($"Dogum gunune {diffMonth} ay qalib.");
            }
            else
            {
                if (now.Day == personBD.Day)
                {
                    diffMonth = now.Month - personBD.Month;
                    if (diffMonth < 6)
                        Console.WriteLine($"Dogum gununden {diffMonth} ay kecib.");
                    else
                    {
                        diffMonth = 12 - now.Month + personBD.Month;
                        Console.WriteLine($"Dogum gunune {diffMonth} ay qalib.");
                    }
                }
                else if (now.Day > personBD.Day)
                {
                    diffMonth = now.Month - personBD.Month;
                    diffDay = now.Day - personBD.Day;
                    if (diffMonth < 6)
                        Console.WriteLine($"Dogum gununden {diffMonth} ay, {diffDay} gun kecib.");
                    else
                    {
                        diffMonth = 12 - now.Month + personBD.Month - 1;
                        DateTime pre = new DateTime(now.Year, now.Month, 1);
                        DateTime post = new DateTime(now.Month + 1 < 13 ? now.Year : now.Year + 1, now.Month + 1 < 13 ? now.Month + 1 : 1, 1);
                        TimeSpan nowMonthTotalDays = post - pre;
                        diffDay = (int)nowMonthTotalDays.TotalDays - now.Day + personBD.Day;
                        Console.WriteLine($"Dogum gunune {diffMonth} ay, {diffDay} gun qalib.");
                    }
                }
                else
                {
                    diffMonth = now.Month - personBD.Month;
                    if (diffMonth < 6)
                    {
                        diffMonth--;
                        DateTime pre = new DateTime(now.Year, now.Month, 1);
                        DateTime post = new DateTime(now.Month + 1 < 13 ? now.Year : now.Year + 1, now.Month + 1 < 13 ? now.Month + 1 : 1, 1);
                        TimeSpan nowMonthTotalDays = post - pre;
                        diffDay = (int)nowMonthTotalDays.TotalDays - personBD.Day + now.Day;

                        Console.WriteLine($"Dogum gununden {(diffMonth > 0 ? diffMonth + " ay, " : "")}{diffDay} gun kecib.");
                    }
                    else
                    {
                        diffMonth = 12 - now.Month + personBD.Month;
                        diffDay = personBD.Day - now.Day;
                        Console.WriteLine($"Dogum gunune {diffMonth} ay, {diffDay} gun qalib.");
                    }
                }
            }
            
        }
    }
}
