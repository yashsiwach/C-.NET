using System;

namespace Time
{
    #region Program Entry Point

    /// <summary>
    /// Program class containing the Main method.
    /// Acts as the entry point of the Time application.
    /// </summary>
    public class Program
    {
        #region Main Method

        /// <summary>
        /// Application execution starts here.
        /// Creates an object of class A and
        /// invokes the Print method.
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
