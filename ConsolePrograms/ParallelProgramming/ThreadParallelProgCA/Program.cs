using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using RegexSampleCA.AppCode.Extensions;

namespace ThreadParallelProgCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("0");
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 800; i++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
                Console.WriteLine();
            });

            thread1.Start();

            //  thread1-e qosuldu ve gozleyir - demekdir join.
            thread1.Join();
            // thread1 bitdikden sonra kodu oxumaga davam edir.

            thread2.Start();


            Thread html1Thread = new Thread(() =>
            {
                ReadEmailsFromUrl("https://localhost:32954", "home/index");
            });
            Thread html2Thread = new Thread(() =>
            {
                ReadEmailsFromUrl("https://localhost:32954", "home/index2");
            });
            Thread html3Thread = new Thread(() =>
            {
                ReadEmailsFromUrl("https://localhost:32954", "home/index3");
            });
            Thread html4Thread = new Thread(() =>
            {
                ReadEmailsFromUrl("https://localhost:32954", "home/index4");
            });
            Thread html5Thread = new Thread(() =>
            {
                ReadEmailsFromUrl("https://localhost:32954", "home/index5");
            });


            html1Thread.Start();
            html2Thread.Start();
            html3Thread.Start();
            html4Thread.Start();
            html5Thread.Start();



            Console.ReadKey();
        }

        private static void ReadEmailsFromUrl(string baseUrl, string link)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            try
            {
                HttpResponseMessage message = client.GetAsync(link).Result;

                if (message.IsSuccessStatusCode)
                {
                    string text = message.Content.ReadAsStringAsync().Result;

                    MatchCollection emails = Regex.Matches(text, Extension.emailInTextPatternForParalleling, RegexOptions.Multiline);

                    foreach (Match email in emails)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(email.Groups["email"].Value);
                    }

                }
                else
                {
                    Console.WriteLine($"{baseUrl}/{link} - Request getmir!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Host ishlemir!");
            }
        }
    }
}
