using System;

namespace ClassWork
{
    /// <summary>
    /// Program to check triangle type
    /// </summary>
    public class TriangleType
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            string? b = Console.ReadLine();
            string? c = Console.ReadLine();

            int x = int.TryParse(a, out x) ? x : 0;
            int y = int.TryParse(b, out y) ? y : 0;
            int z = int.TryParse(c, out z) ? z : 0;
            #endregion

            #region Logic + Output
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Invalid");
            }
            else if (x == y && y == z)
            {
                Console.WriteLine("Equilateral");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
            #endregion
        }
    }
}
