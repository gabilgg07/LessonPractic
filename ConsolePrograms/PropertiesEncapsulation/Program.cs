using System;

namespace PropertiesEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Qabil";
            person.Surname = "Qurbanov";
        l1:
            Console.Write("Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"\n>> {age} can not be an age!\n");
                goto l1;
            }
            try
            {
                person.Age = age;
            }
            catch (Exception)
            {
                Console.WriteLine($"\n>> Age must be big from 0!\n");
                goto l1;
            }
            //Person person = new Person(age);
            //person.Name = "Qabil";
            //person.Surname = "Qurbanov";

            Console.WriteLine($" {person.Name} {person.Surname} {person.Age}");
        }
    }
}
