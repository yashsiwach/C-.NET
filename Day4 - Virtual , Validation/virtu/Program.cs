using System;
using Classwork;

#region Program Entry Point

/// <summary>
/// Program class demonstrating method overriding
/// and runtime behavior using inheritance.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Application execution starts here.
    /// Creates objects of Father and Son classes
    /// and invokes the overridden method.
    /// </summary>
    public static void Main()
    {
        Father obj = new Father();
        Son obj1 = new Son();

        System.Console.WriteLine(obj.Interest());
    }

    #endregion
}

#endregion
