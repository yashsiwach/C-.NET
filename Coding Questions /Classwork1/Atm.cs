using System;

namespace ClassWork
{
    /// <summary>
    /// Program to simulate ATM withdrawal
    /// </summary>
    public class Atm
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration
            string? a = Console.ReadLine();   // card  (1 or 0)
            string? b = Console.ReadLine();   // pin (1 or 0)
            string? c = Console.ReadLine();   // balance
            string? d = Console.ReadLine();   // withdraw 

            int card = int.TryParse(a, out card) ? card : 0;
            int pin = int.TryParse(b, out pin) ? pin : 0;
            int balance = int.TryParse(c, out balance) ? balance : 0;
            int amount = int.TryParse(d, out amount) ? amount : 0;
            #endregion

            #region Logic + Output
            if (card == 1)
            {
                if (pin == 1)
                {
                    if (amount <= balance && amount > 0)
                    {
                        Console.WriteLine(" Successful");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ");
                }
            }
            else
            {
                Console.WriteLine("Card Not Inserted");
            }
            #endregion
        }
    }
}
