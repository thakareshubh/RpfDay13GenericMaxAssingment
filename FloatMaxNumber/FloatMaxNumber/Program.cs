using System;

namespace FloatMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum floating number");
            double doubleMax = CheckFloatMaxNum.GetFloatMaxNumber(45.23, 63.45, 12.36);
            Console.WriteLine(doubleMax);
        }
    }
}
