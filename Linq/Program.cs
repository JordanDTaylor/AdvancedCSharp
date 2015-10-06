using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query Operators
            var booksArray = books as Book[] ?? books.ToArray();
            var cheaperBooks =
                from b in booksArray
                where b.Price < 10
                orderby b.Title
                select b.Title;

            //LINQ Extension Methods (same as above)
            var cheapBooks = booksArray
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b=>b.Title);

            foreach (var b in cheapBooks)
                Console.WriteLine(b);
                //Console.WriteLine(book.Title + " " + book.Price);


            var book = booksArray.Single(b => b.Title == "ASP.Net MVC");

            var lastBook = booksArray.LastOrDefault(b => b.Price > 9);

            var pagedBooks = booksArray.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }
            Console.WriteLine(booksArray.Sum(b=>b.Price));
        }
    }
}
