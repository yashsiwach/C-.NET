using System;

namespace ClassWork
{
    /// <summary>
    /// Program to find the quadrant of a point
    /// </summary>
    public class QuadrantFinder
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            string? b = Console.ReadLine();

            int x = int.TryParse(a, out x) ? x : 0;
            int y = int.TryParse(b, out y) ? y : 0;
            #endregion

            #region Logic + Output
            if (x > 0 && y > 0)
            {
                Console.WriteLine("First Quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Second Quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Third Quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Fourth Quadrant");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if (x == 0)
            {
                Console.WriteLine("On Y-Axis");
            }
            else
            {
                Console.WriteLine("On X-Axis");
            }
            #endregion
        }
    }
}
