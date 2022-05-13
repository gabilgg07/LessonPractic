using System;
namespace BD_Alert_App
{
    public class Person
    {
        public Person(string name, string surname,string email, DateTime bd)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthDay = bd;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public string GetFullName()
        {
            return $" {Name} {Surname}";
        }

    }
}
