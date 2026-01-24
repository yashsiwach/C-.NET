using System;

namespace Taxs
{
    #region Abstract Login Class

    /// <summary>
    /// Abstract base class defining
    /// login-related operations.
    /// </summary>
    public abstract class Loginabs
    {
        #region Abstract Methods

        public abstract void Login(string username, string password);
        public abstract void Logout();

        #endregion

        #region Concrete Methods

        /// <summary>
        /// Prints a simple message.
        /// Can be reused by derived classes.
        /// </summary>
        public void Print()
        {
            System.Console.WriteLine("hello");
        }

        #endregion
    }

    #endregion

    #region Authentication Class

    /// <summary>
    /// Auth class implements Loginabs
    /// and provides authentication logic.
    /// </summary>
    public class Auth : Loginabs
    {
        #region Fields

        private string? username = "test";
        private string? password = "admin";

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Validates username and password
        /// against stored credentials.
        /// </summary>
        public override void Login(string username, string password)
        {
            if (username.Equals(this.username) && password.Equals(this.password))
            {
                System.Console.WriteLine("login success");
            }
            else
            {
                System.Console.WriteLine("incorrect data");
            }
        }

        /// <summary>
        /// Logs the user out.
        /// </summary>
        public override void Logout()
        {
            System.Console.WriteLine("logout");
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Calls the base class Print method.
        /// </summary>
        public void See()
        {
            Print();
        }

        #endregion
    }

    #endregion
}
