using System;
namespace AcademyTask.ConsoleApp.Stucture
{
    public class Person
    {
        public Person(string name, string surname)
        {
            this.name = name;
            this.Surname = surname;

            Console.WriteLine("Persin init");
        }

        private string name;

        public int Id { get; set; }

        // Castom implemention
        public string Name {
            get
            {
                return name;
            }
        }

        // auto implementation
        public string Surname {
            get;
            private set;
        }
    }
}
