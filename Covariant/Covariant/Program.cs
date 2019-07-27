using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<A> elistA = new List<A>() {new A(), new B() };
            Foo(elistA);
            IEnumerable<B> elistB = new List<B>() { new B(), new B(), new B() };
            Foo(elistB);
            IList<B> listB = new List<B>() { new B(), new B(), new B() };
            IList<A> listA = new List<A>() { new A(), new B() };
            Foo3(listA);
            IComparer<A> comp = new Comparer();
            Foo4(comp);
        }

        static void Foo4(IComparer<B> c)
        {
            c.Compare(new B(), new B());
        }

        public static void Foo(IEnumerable<A> enumerable)
        {
            foreach (var item in enumerable)
            {
                item.Hello();
            }
        }

        public static void Foo2(A item)
        {

                item.Hello();

        }

        public static void Foo3(IList<A> list)
        {
            list.Add(new A());
            foreach (var item in list)
            {
                item.Hello();
            }
        }
    }
}
