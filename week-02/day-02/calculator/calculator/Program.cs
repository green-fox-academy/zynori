using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a operation and two numbers: ");
            string inputExpression = Console.ReadLine();

            Console.WriteLine(Calculate(inputExpression));
            Console.ReadLine();            
        }

        static string Calculate(string inputExpression)
        {
            string[] expressionParts = inputExpression.Split(' ');

            if (expressionParts.Length != 3)
            {
                Console.WriteLine("Invalid parameters!");
                return "";
            }

            string[] validOperations = { "+", "-", "/", "*", "%" };

            if (!validOperations.Contains(expressionParts[0]))
            {
                Console.WriteLine("Invalid operation!");
                return "";
            }

            int number1 = int.Parse(expressionParts[1]);
            int number2 = int.Parse(expressionParts[2]);
            double result = 0;

            switch (expressionParts[0])
            {
                case "+":
                    result = AddOperation(number1, number2);
                    break;
                case "-":
                    result = SubOperation(number1, number2);
                    break;
                case "*":
                    result = MultiplyOperation(number1, number2);
                    break;
                case "/":
                    result = DivisionOperation(number1, number2);
                    break;
                case "%":
                    result = PercentageOperation(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    return "";
            }

            return result.ToString();
        }

        private static double AddOperation(int number1, int number2)
        {
            return number1 + number2;
        }

        private static double SubOperation(int number1, int number2)
        {
            return number1 - number2;
        }

        private static double MultiplyOperation(int number1, int number2)
        {
            return number1 * number2;
        }

        private static double DivisionOperation(int number1, int number2)
        {
            return number1 / number2;
        }

        private static double PercentageOperation(int number1, int number2)
        {
            return number1 % number2;
        }
    }
}
// Create a simple calculator application which reads the parameters from the prompt
// and prints the result to the prompt.
// It should support the following operations,
// reate a method named "Calculate()":
// +, -, *, /, % and it should support two operands.
// The format of the expressions must be: {operation} {operand} {operand}.
// Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)
// You can use the Scanner class
// It should work like this:
// Start the program
// It prints: "Please type in the expression:"
// Waits for the user input
// Print the result to the prompt
// Exit