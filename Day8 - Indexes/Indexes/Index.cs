namespace Indexes
{
    #region Indexer Demonstration Class

    /// <summary>
    /// IndexDemo class demonstrates the use of
    /// multiple indexers with different parameter types.
    /// </summary>
    public class IndexDemo
    {
        #region Data Members

        private int[] arr = new int[5];
        private Dictionary<string, int> dict = new Dictionary<string, int>();

        #endregion

        #region Integer Indexer

        /// <summary>
        /// Indexer to access integer array elements
        /// using an integer index.
        /// </summary>
        public int this[int ind]
        {
            get
            {
                return arr[ind];
            }
            set
            {
                arr[ind] = value;
            }
        }

        #endregion

        #region String Indexer

        /// <summary>
        /// Indexer to access dictionary elements
        /// using a string key.
        /// </summary>
        public int this[string str]
        {
            get
            {
                return dict[str];
            }
            set
            {
                dict[str] = value;
            }
        }

        #endregion
    }

    #endregion
}
