using System;

namespace ClassWork
{
    /// <summary>
    /// Program to check if it a leap year 
    /// </summary>
    public class IsLeap
    {
        /// <summary>
        /// method to print the output
        /// </summary>
        public void Print()
        {
            #region Declarations
            string? input = Console.ReadLine();
            int year = int.TryParse(input, out year) ? year : 0;
            #endregion

            #region Logic + output
            ///(year % 400 == 0) OR (year % 4 == 0 AND year % 100 != 0)
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                System.Console.WriteLine("leap");
            }
            else
            {
                System.Console.WriteLine("Not Leap");
            }
            #endregion
        }
    }
}