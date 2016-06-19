using System;

namespace Lab2._2
{
    public class Calculations
    {
        public static double divide(double number1, double number2)
        {
            return (number1 / number2);
        }
        public static double add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double substract(double number1, double number2)
        {
            return number1 - number2;
        }
    }

    public class Calculator
    {
        private static void Main()
        {
            double fNumber = 0;
            double sNumber = 0;
            string userInput;
            bool validOperator = false;

            Console.Write("Insert First Number: ");
            double.TryParse(Console.ReadLine(), out fNumber);
            Console.Write("Insert Second Number: ");
            double.TryParse(Console.ReadLine(), out sNumber);

            while (validOperator == false)
            {
                Console.Write("Insert operator ( + / - * ) that you want: ");
                userInput = Console.ReadLine();

                if (userInput == "/")
                {
                    Console.WriteLine("The Answer is: " + Calculations.divide(fNumber, sNumber));
                    validOperator = true;
                }
                else if (userInput == "+")
                {
                    Console.WriteLine("The Answer is: " + Calculations.add(fNumber, sNumber));
                    validOperator = true; ;
                }
                else if (userInput == "*")
                {
                    Console.WriteLine("The Answer is: " + Calculations.multiply(fNumber, sNumber));
                    validOperator = true;
                }
                else if (userInput == "-")
                {
                    Console.WriteLine("The Answer is: " + Calculations.substract(fNumber, sNumber));
                    validOperator = true;
                }
                else
                {
                    validOperator = false;
                }
            }
        }
    }
}
