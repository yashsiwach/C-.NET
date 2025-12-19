using System;

namespace ClassWork
{
    /// <summary>
    /// Program to check vowel or consonant
    /// </summary>
    public class VowelCheck
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            char ch = char.ToLower(a![0]);
            #endregion

            #region Logic + Output
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;
            }
            #endregion
        }
    }
}
