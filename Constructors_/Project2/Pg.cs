using System;

namespace Data
{
    #region PG Student Class

    /// <summary>
    /// Pg class represents a postgraduate student.
    /// Inherits from the Student base class.
    /// </summary>
    public class Pg : Student
    {
        #region Fields

        /// <summary>
        /// Indicates the study level of the student.
        /// </summary>
        public string study = "PG Student";

        #endregion
    }

    #endregion
}
