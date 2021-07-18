using System;
using CalculatorClassLibrary;

namespace CalculatorConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            System.Console.WriteLine("\nThis is a Simple Console Calculator");
            Console.WriteLine("Please enter an operand (+, -, /, *, ^) for an action to be performed: ");
            calc.Operand = Console.ReadLine();

            switch (calc.Operand)
            {
                case "+":
                    {
                        // System.Console.WriteLine(calc.Addition());
                        // when the method type is void
                        calc.Addition();
                        break;
                    }
                case "-":
                    {
                        calc.Subtraction();
                        break;
                    }
                case "*":
                    {
                        calc.Multiplication();
                        break;
                    }
                case "/":
                    {
                        calc.Division();
                        break;
                    }
                case "^":
                    {
                        calc.SquareNum();
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! Please try again");
                    break;
            }

        }
    }
}

