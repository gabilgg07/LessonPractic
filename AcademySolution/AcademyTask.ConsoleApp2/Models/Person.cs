using System;
namespace AcademyTask.ConsoleApp2.Models
{
    public class Person
    {
        static int counter = 0;
        public Person(string name, string surname, PersonType type)
        {
            this.Id = ++counter;
            this.Name = name;
            this.Surname = surname;
            this.Type = type;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public PersonType Type { get; private set; }

        public override string ToString()
        {
            if (Type == PersonType.Teacher || Type == PersonType.Mentor)
            {
                return $" {Name} {Surname}";
            }
            else
            {
                return $"{Id}. {Name} {Surname}";
            }
        }

    }
}
