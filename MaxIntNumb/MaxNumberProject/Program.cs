using System;

namespace MaxNumberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum number between three integer number");
            int intMax = MaxIntNumber.GetMaxNumber(5, 4, 45);
            Console.WriteLine(intMax);
        }
    }
}
