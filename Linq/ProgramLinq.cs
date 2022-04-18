using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Linq
{
    internal class ProgramLinq
    {
        public static void ProgramLinqViod()
        {
            var books = new BookRepository().GetBooks();


            // LINQ Query Operator

            var cheaperBooks =
                    from b in books
                    where b.Price < 10
                    orderby b.Title
                    select b.Title;




            // LINQ extension methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);


            //var cheapBooks = new List<Book>();
            //foreach ( var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            foreach ( var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }


            var boook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(boook.Title);
            Console.WriteLine("---------------");
            var bok = books.Skip(2).Take(3);
            foreach (var page in bok)
            {
                Console.WriteLine(page.Title);
            }
            Console.WriteLine("---------------");

            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine("---------------");
            var maxPrice = books.Max( b => b.Price );
            Console.WriteLine(maxPrice);


        }
    }
}
