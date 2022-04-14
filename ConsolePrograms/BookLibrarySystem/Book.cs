using System;
using System.Collections.Generic;

namespace BookLibrarySystem
{
    public class Book : Identity
    {
        static int counter = 0;

        public Book()
        {
            Id = ++counter;
            Editions = new List<string>();
        }

        public string Name { get; set; }
        public DateTime PublishedDate { get; set; }
        public ushort PageCount { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public List<string> Editions { get; set; }

        public override string ToString()
        {
            return $"Book: [{Name}]({PageCount}) - {PublishedDate:yyyy}\n" +
                $"{(Editions.Count>0?$"Editions: {string.Join(", ", Editions)}\n":"")}" +
                $"Category: {Category}\n" +
                $"Author: {Author}\n" +
                $"{new string('-', Console.WindowWidth)}";
        }
    }

}
