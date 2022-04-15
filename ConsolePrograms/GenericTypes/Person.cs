using System;
namespace GenericTypes
{
    public class Person : Entity
    {
        public Person()
        {
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
    public class Gender : Entity
    {

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Entity
    {
        public int Id { get; set; }
    }
}
