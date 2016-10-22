namespace _05_BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library lib = new Library();
            List<Book> books = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                // format {title} {author} {publisher} {release date} {ISBN} {price}.
                string[] b = Console.ReadLine().Split(' ');

                Book book = new Book()
                {
                    Title = b[0],
                    Author = b[1],
                    Publisher = b[2],
                    ReleaseDate = b[3],
                    Isbn = b[4],
                    Price = decimal.Parse(b[5])
                };

                books.Add(book);
            }

            lib.Books = books;

            // Ask Simo how to do the below code in Lambda expression
            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();
            Dictionary<string, Dictionary<string, decimal>> authors2 = new Dictionary<string, Dictionary<string, decimal>>();

            foreach (var book in lib.Books)
            {
                if (!authors.ContainsKey(book.Author))
                {
                    Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
                    dict.Add(book.Title, book.Price);

                    authors2.Add(book.Author, dict);
                }
                else
                {
                    authors2[book.Author][book.Title] += book.Price;
                }

            }

            //foreach (Book book in lib.Books)
            //{
            //    if (!authors.ContainsKey(book.Author))
            //    {
            //        authors.Add(book.Author, book.Price);
            //    }
            //    else
            //    {
            //        authors[book.Author] += book.Price;
            //    }
            //}

            foreach (var item in authors.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine("{0} -> {1:0.00}", item.Key, Math.Round(item.Value, 2));
            }
        }

        
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        //title, author, publisher, release date, ISBN-number and price. 
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }
}
