using System;

namespace Time
{
    #region Time Conversion Class

    /// <summary>
    /// Class A converts total seconds into
    /// hours, minutes, and seconds format.
    /// Handles validation and edge cases.
    /// </summary>
    public class A
    {
        #region Methods

        /// <summary>
        /// Reads seconds from user input,
        /// validates numeric and non-negative values,
        /// converts seconds into hours, minutes, and seconds,
        /// and prints the formatted time.
        /// </summary>
        public void Print()
        {
            string str = Console.ReadLine();

            if (!int.TryParse(str, out int sec))
            {
                Console.WriteLine("invalid");
            }
            else if (sec < 0)
            {
                Console.WriteLine("negetive time");
            }
            else
            {
                int hours = sec / 3600;
                sec = sec % 3600;

                int min = sec / 60;
                sec = sec % 60;

                Console.WriteLine($"{hours} : {min} : {sec}");
            }
        }

        #endregion
    }

    #endregion
}
