using System;
using System.Collections.Generic;
using Helper;

namespace BookLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>();

            authors.AddRange(
                new[]
                {
                    new Author(){Name = "Cingiz", Surname="Abdullayev"},
                    new Author(){Name = "Elxan", Surname="Elatli"},
                    new Author(){Name = "Mark", Surname="Tven"}
                }
                );

            Book book1 = new Book() {
                Name = "Qerb burkusu",
                PageCount = 400,
                PublishedDate = new DateTime(2003, 10, 1),
                Category = Category.Detective,
                Author = authors[0]
            };

            book1.Editions.Add("1-ci nesr"); 
            book1.Editions.Add("2-ci nesr");



            Book book2 = new Book();
            book2.Name = "Dilenci qadinin sirri";
            book2.PageCount = 359;
            book2.PublishedDate = new DateTime(2004, 8, 6);
            book2.Category = Category.Classics;
            book2.Author = authors[1];

            Book book3 = new Book();
            book3.Name = "Bir-birimize demediyimiz sozler";
            book3.PageCount = 246;
            book3.PublishedDate = new DateTime(2006, 3, 17);
            book3.Category = Category.Historical;
            book3.Author = authors[2];

            List<Book> books = new List<Book>() {book1,book2,book3 };

            PrintBooks(books);

            Console.ReadKey();
        }

        private static void PrintBooks(List<Book> books)
        {
            ConsoleHelper.Header("Book", ')','(',ConsoleColor.Blue);

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}
