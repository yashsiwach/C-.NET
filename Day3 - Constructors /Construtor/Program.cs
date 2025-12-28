using System;
using Con;

#region Program Entry Point

/// <summary>
/// Program class demonstrating object creation
/// using a public parameterized constructor.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Application entry point.
    /// Shows that the default constructor is blocked
    /// and only the parameterized constructor can be used.
    /// </summary>
    public static void Main(string[] args)
    {
        // A obj = new A();   // blocked due to private constructor
        A obj1 = new A("test");
        System.Console.WriteLine(obj1.name);
    }

    #endregion
}

#endregion
