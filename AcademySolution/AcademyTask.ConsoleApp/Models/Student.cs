using System;
using AcademyTask.ConsoleApp.Stucture;

namespace AcademyTask.ConsoleApp.Models
{
    public class Student : Person
    {
        static int counter = 0;
        public Student(string name, string surname)
            :base(name,surname)
        {
            this.id = ++counter;
            Console.WriteLine("Student init");
        }

        public override string ToString()
        {
            return $"Student: {Id}. {Name} {Surname}";
        }
    }
}
