using System;
namespace AcademyTask.ConsoleApp.Stucture
{
    public class Person
    {
       
        public Person(string name, string surname)
        {
            this.name = name;
            Surname = surname;

            Console.WriteLine("Persin init");
        }

        private string name;
        protected int id;

        public int Id {
            get {
                return id;
            }
        }

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
