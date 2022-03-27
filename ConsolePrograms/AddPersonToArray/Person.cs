using System;
namespace AddPersonToArray
{
    public class Person
    {
        public Person(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        // fields
        internal string Name;
        internal string Surname;
        internal byte Age;

        public override string ToString()
        {
            return $" {Name} {Surname} ({Age})";
        }
    }
}
