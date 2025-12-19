using System;
namespace ClassWork
{
    /// <summary>
    /// Quadratic Equation: Calculate roots of $ax^2 + bx + c = 0$ using if-else to check the discriminant.
    /// </summary>
    public class Roots
    {
        /// <summary>
        /// Method to print the output 
        /// </summary>
        public void Print()
        {

            #region Declaration
            string? input1 = Console.ReadLine();
            string? input2 = Console.ReadLine();
            string? input3 = Console.ReadLine();

            double a = double.TryParse(input1, out a) ? a : 0;
            double b = double.TryParse(input2, out b) ? b : 0;
            double c = double.TryParse(input3, out c) ? c : 0;
            double d = b * b - 4 * a * c;
            #endregion

            #region Logic 
            if (d > 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2 * a);
                System.Console.WriteLine($"{r1} {r2}");
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Complex roots");
            }

            #endregion

        }
    }
}