using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Generics
{
    internal class Program_Generics
    {
        public static void GenericsVoid()
        {
            var book = new Book { Isbn = "1111", Title="C# Advanced"};

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            //constraint for generics
            // where T : IComparable - ograniczenie do wszystkiego co zaimplementowao interfejs
            // where T : Product - ograniczenie do klasy product albo jej subklasses
            // where T : struct - ograniczenie do value type
            // where T : class - ograniczenie do reference type
            // where T : new() - ograniczenie do klasy ktora ma konstruktor domyslny




            //2. where T : Product - ograniczenie do klasy product albo jej subklasses
            var discProd = new DiscountProduct<Product>();
            discProd.Add(new Book());
            discProd.Add(new Kindle());



            //3. where T : struct - ograniczenie do value type
            var num = new  Nullable<int>(5);
            Console.WriteLine("Has value? " + num.HasValue);
            Console.WriteLine("Value: " + num.GetValueOrDefault());

        }
    }
}
