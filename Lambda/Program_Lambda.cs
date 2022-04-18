using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Lambda
{
    internal class Program_Lambda
    {

        // lambda niczego nie zwraca
        // args => execution
        // num => num * num

       
        public static void LambdaVoid()
        {
            const int factor = 9;
            Func<int, int> square = num => num * num; // trzeba uzyc delegate
            //Console.WriteLine(square(22));
            Func<int, int> multiply = n => n * factor;
            Console.WriteLine(multiply(5));

            var books = new BookRepository().GetBooks();
            //var cheaperBooks = books.FindAll(IsCheaperThan10Dollar);
            //lub uzyc Lambda
            var cheaperBooks = books.FindAll(book => book.Price < 10);// w przypadku Findall musi zwracac bool

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollar(Book book)
        {
            return book.Price < 10;
        }


    }    
}
