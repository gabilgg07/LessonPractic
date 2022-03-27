using System;
namespace InheritenceLesson
{
    public class Person
    {
        public Person(string name, string surname, DateTime bd)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthOfDate = bd;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthOfDate { get; set; }

        public override string ToString()
        {
            return $">> {Name} {Surname} - ({BirthOfDate.ToString("dd.MM.yyyy")}) ";
        }

        public virtual string VitualMethodForOverride()
        {
            return $">> Hello, my name is {Name}.";
        }
    }
}
