using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant
{
    class Comparer : IComparer<A>
    {
        public int Compare(A x, A y)
        {
            return 0;
        }
    }
}
