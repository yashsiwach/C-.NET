using System;

namespace ClassWork
{
    /// <summary>
    /// Program to perform simple calculator operations
    /// </summary>
    public class Calc
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();   // first number
            string? b = Console.ReadLine();   // second number
            string? op = Console.ReadLine();  // operator

            double x = double.TryParse(a, out x) ? x : 0;
            double y = double.TryParse(b, out y) ? y : 0;
            char oper = op![0];
            #endregion

            #region Logic + Output
            switch (oper)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;

                case '-':
                    Console.WriteLine(x - y);
                    break;

                case '*':
                    Console.WriteLine(x * y);
                    break;

                case '/':
                    if (y != 0)
                        Console.WriteLine(x / y);
                    else
                        Console.WriteLine("Division by zero not allowed");
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            #endregion
        }
    }
}
