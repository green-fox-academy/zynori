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
            Console.WriteLine("Please type in the expression: ");
            string yourInput = Console.ReadLine();
            Console.WriteLine(Calculate(yourInput));
            Console.ReadLine();
            
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
        }

        public static string Calculate(string yourInput)
        {
            string[] splitInput = yourInput.Split(' ');
            string myOrerator = splitInput[0];
            double firstNumber = Convert.ToDouble(splitInput[1]);
            double secondNumber = Convert.ToDouble(splitInput[2]);

            if (myOrerator == "+")
            {
                double mySolution = firstNumber + secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "-")
            {
                double mySolution = firstNumber - secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "*")
            {
                double mySolution = firstNumber * secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "/")
            {
                double mySolution = firstNumber / secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOrerator == "%")
            {
                double mySolution = firstNumber % secondNumber;
                return "Your solution is " + mySolution;
            }
            else
            {
                return "Please specify your input";
            }
        }
    }
}
