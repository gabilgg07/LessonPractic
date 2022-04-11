using System;
using AcademyTask.ConsoleApp.Stucture;

namespace AcademyTask.ConsoleApp.Models
{
    public class Mentor : Person
    {
        static int counter = 0;
        public Mentor(string name, string surname)
            : base(name, surname)
        {
            id = ++counter;
        }

        public override string ToString()
        {
            return $"Mentor: {Id}. {Name} {Surname}";
        }
    }
}
