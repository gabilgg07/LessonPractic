using System;
using Helper;

namespace InheritenceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Person person = new Person("Samir", "Selimov", new DateTime(1996, 2, 4));

            Employee employee = new Employee("Qabil", "Qurbanov", new DateTime(1991,7,7));

            Console.WriteLine(person);
            Console.WriteLine(person.BirthOfDate.ToShortDateString());
            Console.WriteLine(person.VitualMethodForOverride());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(employee);
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.VitualMethodForOverride());

            Console.ReadKey();
        }
    }
}
