using System;

namespace Area
{
    #region Area Calculation Class

    /// <summary>
    /// Class to calculate the area of a circle
    /// using the formula: π × r × r.
    /// </summary>
    public class A
    {
        #region Properties

        /// <summary>
        /// Stores the radius of the circle.
        /// </summary>
        public float Radius { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Reads radius from user input,
        /// calculates the area of the circle,
        /// and prints the result.
        /// </summary>
        public void Print()
        {
            float a = Convert.ToSingle(Console.ReadLine());
            Radius = a;

            const float pi = 3.14f;
            Console.WriteLine(a * pi * a);
        }

        #endregion
    }

    #endregion
}
