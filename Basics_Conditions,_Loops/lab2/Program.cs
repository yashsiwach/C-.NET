using System;

namespace Feet
{
    #region Program Entry Point

    /// <summary>
    /// Program class containing the Main method.
    /// Acts as the entry point of the application.
    /// </summary>
    public class Program
    {
        #region Main Method

        /// <summary>
        /// Application execution starts here.
        /// Creates an object of class A and
        /// calls the Print method to perform conversion.
        /// </summary>
        public static void Main()
        {
            A obj = new A();
            obj.Print();
        }

        #endregion
    }

    #endregion
}
