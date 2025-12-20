using System.Collections;

namespace Game
{
    public class MatchWonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Competition a = (Competition)x;
            Competition b = (Competition)y;

            return a.matchWon.CompareTo(b.matchWon); 
        }
    }
}
