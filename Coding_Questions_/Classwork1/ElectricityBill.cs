using System;

namespace ClassWork
{
    /// <summary>
    /// Program to calculate electricity bill
    /// </summary>
    public class ElectricityBill
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            int units = int.TryParse(a, out units) ? units : 0;
            double bill = 0;
            #endregion

            #region Logic + Output
            if (units <= 199)
                bill = units * 1.20;
            else if (units <= 400)
                bill = 199 * 1.20 + (units - 199) * 1.50;
            else if (units <= 600)
                bill = 199 * 1.20 + 201 * 1.50 + (units - 400) * 1.80;
            else
                bill = 199 * 1.20 + 201 * 1.50 + 200 * 1.80 + (units - 600) * 2.00;

            if (bill > 400)
                bill += bill * 0.15;

            Console.WriteLine($"{bill:F2}");
            #endregion
        }
    }
}
