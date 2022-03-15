using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1_GenericMaxNumber
{
    internal class FindMax<T> where T : IComparable
    {
        public T First;
        public T Second;
        public T Third;

        public  FindMax(T first,T Second,T Third)
        {
            this.First=first;
            this.Third=Third;
            this.Second = Second;
        }

        public void GetMaxNUmber()
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine($"{First} is maximum");
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine($"{Second} is maximum");
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0) 
            {
                Console.WriteLine($"{Third} is maximum");
            }
           
        }

    }
}
