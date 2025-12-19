using System;

namespace ClassWork
{
    /// <summary>
    /// Program to print grade description
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            char grade = char.ToUpper(a![0]);
            #endregion

            #region Logic + Output
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;

                case 'V':
                    Console.WriteLine("Very Good");
                    break;

                case 'G':
                    Console.WriteLine("Good");
                    break;

                case 'A':
                    Console.WriteLine("Average");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            #endregion
        }
    }
}
