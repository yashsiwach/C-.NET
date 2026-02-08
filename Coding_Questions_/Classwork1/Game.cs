using System;

namespace ClassWork
{
    /// <summary>
    /// Rock Paper Scissors: Logic for a 2-player game using nested conditionals.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Method to Play the game
        /// </summary>
        public void Print()
        {
            #region Declarations of Variable
            string? input1;
            string? input2;
            int first = 0;
            int second = 0;
            #endregion

            #region Logic + Output 
            while (first == second)
            {
                Console.WriteLine("player 1");
                input1 = Console.ReadLine();

                Console.WriteLine("player 2");
                input2 = Console.ReadLine();

                first = int.TryParse(input1, out first) ? first : 0;
                second = int.TryParse(input2, out second) ? second : 0;

                // Player one picks 1 = Stone
                if (first == 1)
                {
                    if (second == 2)
                    {
                        Console.WriteLine("second player win");
                        break;
                    }
                    else if (second == 3)
                    {
                        Console.WriteLine("first player win");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("draw");
                    }
                }
                else if (first == 2)
                {
                    if (second == 1)
                    {
                        Console.WriteLine("first player win");
                        break;
                    }
                    else if (second == 3)
                    {
                        Console.WriteLine("second player win");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("draw");
                    }
                }
                else
                {
                    if (second == 1)
                    {
                        Console.WriteLine("second player win");
                        break;
                    }
                    else if (second == 3)
                    {
                        Console.WriteLine("draw");
                    }
                    else
                    {
                        Console.WriteLine("first player win");
                        break;
                    }
                }
            }
            #endregion
        }
    }
}
