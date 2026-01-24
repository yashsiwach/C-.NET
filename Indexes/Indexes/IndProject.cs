namespace Indexes
{
    #region Student Class with Indexer

    /// <summary>
    /// Student class demonstrates the use of
    /// indexers to access internal data like an array.
    /// </summary>
    public class Student
    {
        #region Data Members

        private string[] books = new string[2];

        #endregion

        #region Properties

        public int RNo { get; set; }
        public string? SName { get; set; }

        #endregion

        #region Indexer

        /// <summary>
        /// Indexer to get or set book names
        /// using array-style access on the object.
        /// </summary>
        public string this[int ind]
        {
            get
            {
                return books[ind];
            }
            set
            {
                books[ind] = value;
            }
        }

        #endregion
    }

    #endregion
}
