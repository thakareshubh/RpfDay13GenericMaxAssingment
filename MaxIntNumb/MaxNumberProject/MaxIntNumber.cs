using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberProject
{
    internal class MaxIntNumber
    {
        ///Mehthod is creating for maximum intger number 
        public static int GetMaxNumber(int first,int second,int third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third) >0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) >0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            throw new Exception("three numbers are same");
        }

      
    }
}
