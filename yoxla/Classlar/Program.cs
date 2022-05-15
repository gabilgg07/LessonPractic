using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Qabil", "Qurbanov");

            Console.WriteLine(person1.Name);

            Console.WriteLine(person1.GetFullname());

            Calculator calc = new Calculator();

            int sum = calc.Cem(7, 6);

            Console.WriteLine($"Cem: {sum}");

            int diff = calc.Ferq(7, 6);

            Console.WriteLine($"Ferq: {diff}");

            int mult = calc.Hasil(7, 6);

            Console.WriteLine($"Hasil: {mult}");

            int div = calc.Qismet(76, 6);

            Console.WriteLine($"Qismet: {div}");

            Client client1 = new Client("123.4.3.0.0",6504);

            Console.WriteLine(client1.IsConnected);
            client1.Connect();
            Console.WriteLine(client1.IsConnected);
            client1.Disconnect();
            Console.WriteLine(client1.IsConnected);
            Console.ReadKey();

        }
    }
}
