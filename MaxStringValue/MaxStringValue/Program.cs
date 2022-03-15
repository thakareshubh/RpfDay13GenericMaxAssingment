using System;

namespace MaxStringValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the maximum string value");
            string stringValue = GetMaxString.MaxString("Alpha", "Beta", "Gama");
            Console.WriteLine(stringValue);
        }
    }
}
