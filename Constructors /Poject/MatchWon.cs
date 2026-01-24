using System.Collections;

namespace Game
{
    #region Comparer Class

    /// <summary>
    /// Compares two Competition objects
    /// based on the number of matches won.
    /// </summary>
    public class MatchWonComparer : IComparer
    {
        #region Methods

        /// <summary>
        /// Compares two objects of type Competition
        /// using the matchWon property.
        /// </summary>
        /// <param name="x">First Competition object</param>
        /// <param name="y">Second Competition object</param>
        /// <returns>
        /// Less than zero if x is less than y,
        /// zero if equal,
        /// greater than zero if x is greater than y.
        /// </returns>
        public int Compare(object x, object y)
        {
            Competition a = (Competition)x;
            Competition b = (Competition)y;

            return a.matchWon.CompareTo(b.matchWon);
        }

        #endregion
    }

    #endregion
}
