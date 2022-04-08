using System;
using AcademyTask.ConsoleApp.Stucture;

namespace AcademyTask.ConsoleApp.Models
{
    public class Student : Person
    {
        public Student(string name, string surname)
            :base(name,surname)
        {

            Console.WriteLine("Student init");
        }
    }
}
