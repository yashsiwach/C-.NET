using System;

namespace ClassWork
{
    /// <summary>
    /// Program to calculate profit or loss percentage
    /// </summary>
    public class ProfitLoss
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();
            string? b = Console.ReadLine(); 

            double cp = double.TryParse(a, out cp) ? cp : 0;
            double sp = double.TryParse(b, out sp) ? sp : 0;
            #endregion

            #region Logic + Output
            if (cp <= 0)
            {
                Console.WriteLine("Invalid");
            }
            else if (sp > cp)
            {
                double profitPercent = ((sp - cp) / cp) * 100;
                Console.WriteLine($"Profit {profitPercent:F2}%");
            }
            else if (sp < cp)
            {
                double lossPercent = ((cp - sp) / cp) * 100;
                Console.WriteLine($"Loss {lossPercent:F2}%");
            }
            else
            {
                Console.WriteLine("No Profit No Loss");
            }
            #endregion
        }
    }
}
