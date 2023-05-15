using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            char op = char.Parse(Console.ReadLine());

            double result = Program.Calculate(num1, num2, op);

            Console.WriteLine($"Result: {result}");
        }
        public static double Calculate(double num1, double num2, char op)
        {
            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            return result;
        }
    }
}
