using System;

namespace Lab2._2
{
    public class Calculations
    {
        public static double Divide(double number1, double number2)
        {
            return (number1 / number2);
        }
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }
    }

    public class Calculator
    {
        private static void Main()
        {
            double fNumber;
            double sNumber;
            string userInput;
            var validOperator = false;

            Console.Write("Insert First Number: ");
            double.TryParse(Console.ReadLine(), out fNumber);
            Console.Write("Insert Second Number: ");
            double.TryParse(Console.ReadLine(), out sNumber);

            while (validOperator == false)
            {
                Console.Write("Insert operator ( + / - * ) that you want: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "/":
                        Console.WriteLine("The Answer is: " + Calculations.Divide(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "+":
                        Console.WriteLine("The Answer is: " + Calculations.Add(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "*":
                        Console.WriteLine("The Answer is: " + Calculations.Multiply(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "-":
                        Console.WriteLine("The Answer is: " + Calculations.Substract(fNumber, sNumber));
                        validOperator = true;
                        break;
                }
            }
        }
    }
}
