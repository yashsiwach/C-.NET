using System;
using System.Collections;

namespace Game
{
    #region Result Processing Class

    /// <summary>
    /// Result class processes employee data,
    /// filters playing employees, sorts them
    /// based on matches won, and displays results.
    /// </summary>
    public class Result
    {
        #region Methods

        /// <summary>
        /// Filters employees who are playing,
        /// converts them into Competition objects,
        /// sorts them using MatchWonComparer,
        /// and prints the final result.
        /// </summary>
        /// <param name="arr">Array of Employee objects</param>
        /// <param name="size">Number of employees</param>
        public void Playing(Employee[] arr, int size)
        {
            ArrayList part = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                if (arr[i].isPlaying)
                {
                    Competition obj = new Competition(arr[i]);
                    part.Add(obj);
                }
            }

            part.Sort(new MatchWonComparer());

            foreach (object i in part)
            {
                Competition c = (Competition)i;
                Console.WriteLine(c.playerID + " " + c.playerName + " " + c.matchWon);
            }
        }

        #endregion
    }

    #endregion
}
