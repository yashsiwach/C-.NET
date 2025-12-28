using System;

namespace ClassWork
{
    /// <summary>
    /// Largest of Three: Take three integers and find the maximum using nested if.
    /// </summary>
    public class Largest3
    {
        /// <summary>
        /// Method to print the output 
        /// </summary>
        public void Print()
        {
            #region Declarations
            String?a = Console.ReadLine();
            String?b = Console.ReadLine();
            String?c = Console.ReadLine();
            int first= int.TryParse(a,out first)?first:0;
            int second =int.TryParse(b,out second)?second:0;
            int third = int.TryParse(c,out third)?third:0;
            #endregion

            #region Logic + output
            if (first > second)
            {
                if (first > third)
                {
                    System.Console.WriteLine(first);
                }
            }
            else if (second > first)
            {
                if (second > third)
                {
                    System.Console.WriteLine(second);
                }
            }
            if (third > first)
            {
                if (third > second)
                {
                    System.Console.WriteLine(third);
                }
            }
            #endregion
        }
    }
}