namespace _06_BookLibraryModification
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    public class _06_BookLibraryModification
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
                    ReleaseDate = DateTime.ParseExact(b[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                    Isbn = b[4],
                    Price = decimal.Parse(b[5])
                };

                books.Add(book);
            }

            lib.Books = books;

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            List<Book> titleAfterDate = lib.Books.Where(b => b.ReleaseDate > date).OrderBy(x =>x.ReleaseDate).ThenBy(x => x.Title).ToList();

            foreach (Book book in titleAfterDate)
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
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
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }
}
