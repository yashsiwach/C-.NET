using System;

namespace Con
{
    #region Class Definition

    /// <summary>
    /// Class A demonstrates constructor usage
    /// with a private default constructor and
    /// a public parameterized constructor.
    /// </summary>
    public class A
    {
        #region Properties

        /// <summary>
        /// Stores the name value.
        /// Nullable string property.
        /// </summary>
        public string? name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private default constructor.
        /// Prevents object creation without parameters.
        /// </summary>
        private A()
        {
        }

        /// <summary>
        /// Public constructor that initializes the name.
        /// </summary>
        /// <param name="name">Name to assign</param>
        public A(string name)
        {
            this.name = name;
        }

        #endregion
    }

    #endregion
}
