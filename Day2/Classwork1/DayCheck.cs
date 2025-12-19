using System;

namespace ClassWork
{
    /// <summary>
    /// Program to check valid calendar date
    /// </summary>
    public class DayCheck
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

            int day = int.TryParse(a, out day) ? day : 0;
            int month = int.TryParse(b, out month) ? month : 0;
            int year = int.TryParse(c, out year) ? year : 0;
            #endregion

            #region Logic + Output
            bool isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            bool valid = true;

            if (year <= 0 || month < 1 || month > 12 || day < 1)
            {
                valid = false;
            }
            else
            {
                switch (month)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        valid = day <= 31;
                        break;

                    case 4: case 6: case 9: case 11:
                        valid = day <= 30;
                        break;

                    case 2:
                        valid = isLeap ? day <= 29 : day <= 28;
                        break;
                }
            }

            if (valid)
                Console.WriteLine("Valid ");
            else
                Console.WriteLine("Invalid ");
            #endregion
        }
    }
}
