using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Nullable
{
    internal class ProgramNullable
    {
        public static void ProgramNullableVoid()
        {
            Nullable<DateTime> date = null; // to jest == DateTime? dateTime = null;
            DateTime? dateTime = null;

            Console.WriteLine(dateTime.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            Console.WriteLine(date.Value);

            DateTime? datetime = new DateTime(1, 2, 2020);
            DateTime datetime2 = datetime.GetValueOrDefault();

            DateTime datetime3 = date ?? DateTime.Today;
            // == 
            DateTime datetime4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



        }
    }
}
