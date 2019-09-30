using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1
{
    class ComparaMedie:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Medie() > y.Medie())
                return 1;
            else if (x.Medie() == y.Medie())
                return 0;
            else
                return -1;
        }
    }
}
