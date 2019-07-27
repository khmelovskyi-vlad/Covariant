using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant
{
    class B:A
    {
        public override void Hello()
        {
            Console.WriteLine("B");
        }
    }
}
