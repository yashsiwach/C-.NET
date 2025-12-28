using System;

namespace ClassWork
{
    /// <summary>
    /// Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
    /// </summary>
    public class Height
    {
        /// <summary>
        /// Method to print the output 
        /// </summary>
        public void Print()
        {
            #region Declarations
            string? input = Console.ReadLine();
            int height = int.TryParse(input, out height)? height:0;
            #endregion

            #region Logic + Output
            if (height < 150)
            {
                System.Console.WriteLine("Dwarf");
            }
            else if (height >= 150 && height <= 165)
            {
                System.Console.WriteLine("Average");
            }
            else if (height > 165 && height <= 190)
            {
                System.Console.WriteLine("tall");
            }
            else
            {
                System.Console.WriteLine("abnormal");
            }
            #endregion
        }
    }
}