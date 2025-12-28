using System;

namespace Area
{
    #region Area Calculation with Validation

    /// <summary>
    /// Class B calculates the area of a circle
    /// using validated user input.
    /// </summary>
    public class B
    {
        #region Methods

        /// <summary>
        /// Continuously reads radius input from the user.
        /// Stops when -1 is entered.
        /// Validates input using double.TryParse,
        /// checks for negative values,
        /// calculates and prints the area formatted to 2 decimals.
        /// </summary>
        public void Print()
        {
            string Radi;

            while ((Radi = Console.ReadLine()) != "-1")
            {
                if (!double.TryParse(Radi, out double radius))
                {
                    Console.WriteLine("invalid");
                }
                else if (radius < 0)
                {
                    Console.WriteLine("less than 0");
                }
                else
                {
                    double area = Math.PI * radius * radius;
                    Console.WriteLine($"{area:F2}");
                }
            }
        }

        #endregion
    }

    #endregion
}
