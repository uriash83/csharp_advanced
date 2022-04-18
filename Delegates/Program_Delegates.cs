using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Delegates
{
    internal class Program_Delegates
    {
        public static void DelegatesVoid()
        {
            var processor = new  PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast; // dodanie do handelra kolejnej funkcji
            filterHandler += RemoveFilters;



            processor.Process("bla.jpg", filterHandler);


        }

        static void RemoveFilters(Photo photo)
        {
            Console.WriteLine("Remove filters from photo");
        }
    }
}
