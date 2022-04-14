using System;
namespace BookLibrarySystem
{
    public class Author : Identity
    {
        public Author()
        {
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
