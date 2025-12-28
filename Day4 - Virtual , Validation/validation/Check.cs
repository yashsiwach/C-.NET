using System;

namespace Valid
{
    #region Validation Class

    /// <summary>
    /// Check class demonstrates validation logic
    /// using properties with custom getters and setters.
    /// </summary>
    public class Check
    {
        #region Fields

        int id;
        private string name;
        string? rank;

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must be positive");

                id = value;
            }
        }

        public string? Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Must be not Null");
                else if (value.Length < 3)
                    throw new ArgumentException("should not be less than 3");

                name = value;
            }
        }

        public string? Rank
        {
            get { return rank; }
            set
            {
                if (value == null)
                    throw new ArgumentException("should not be null");
                else if (value == "manager" || value == "intern")
                    rank = value;
                else
                    throw new ArgumentException(" outsider");
            }
        }

        #endregion
    }

    #endregion
}
