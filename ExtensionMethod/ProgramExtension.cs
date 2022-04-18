using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.ExtensionMethod
{
    internal class ProgramExtension
    {
        public static void ProgramExtensionVoid()
        {
            string post = "It is a very long long long post";
            Console.WriteLine(post.Shorten(-9));// metoda jest statyczna ale uzywamy jej na instancji

        }
    }
}
