using System;

namespace Refactor1_GenericMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMax<int> max = new FindMax<int>(45, 86, 36);
            max.GetMaxNUmber();
            FindMax<double> max2 = new FindMax<double>(1.6, 0045.9, 32.6);
            max2.GetMaxNUmber();
            FindMax<string> max3 = new FindMax<string>("456", "asdf", "2");
            max3.GetMaxNUmber();
        }
    }
}
