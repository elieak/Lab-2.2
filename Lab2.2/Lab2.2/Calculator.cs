using System;

namespace Lab2._2
{
    public class Calculations
    {
        public double Divide(double number1, double number2)
        {
            try
            {
                if (number2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return (number1 / number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("blaaaaaaaaaaaaaaaaaa");
                return double.NaN;
            }
            
        }
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public double Substract(double number1, double number2)
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
            Calculations myCalculations = new Calculations();

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
                        Console.WriteLine("The Answer is: " + myCalculations.Divide(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "+":
                        Console.WriteLine("The Answer is: " + myCalculations.Add(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "*":
                        Console.WriteLine("The Answer is: " + myCalculations.Multiply(fNumber, sNumber));
                        validOperator = true;
                        break;
                    case "-":
                        Console.WriteLine("The Answer is: " + myCalculations.Substract(fNumber, sNumber));
                        validOperator = true;
                        break;
                }
            }
        }
    }
}
