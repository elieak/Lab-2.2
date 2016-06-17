using System;

namespace Lab2._2
{
    internal class Calculator
    {
        private static void Main()
        {
            int fNumber = 0;
            int sNumber = 0;
            Console.Write("Insert First Number: ");
            int.TryParse(Console.ReadLine(), out fNumber);
            Console.Write("Insert Second Number: ");
            int.TryParse(Console.ReadLine(), out sNumber);
        }
    }
}
