using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Dynamics
{
    internal class ProgramDynamic
    {
        public static void ProgramDynamicVoid()
        {
            // w dynamic types trzeba pisac wiecej testow
            dynamic name = "martin";
            //name = 10;// nie ma problemu z takim przypisaniem
            name++;
        }
    }
}
