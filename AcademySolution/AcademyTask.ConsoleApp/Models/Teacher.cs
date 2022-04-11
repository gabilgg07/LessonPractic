using System;
using AcademyTask.ConsoleApp.Stucture;

namespace AcademyTask.ConsoleApp.Models
{
    public class Teacher : Person
    {
        static int counter = 0;
        public Teacher(string name, string surname)
            : base(name, surname)
        {
            id = ++counter;
        }

        public override string ToString()
        {
            return $"Teacher: {Id}. {Name} {Surname}";
        }
    }
}
