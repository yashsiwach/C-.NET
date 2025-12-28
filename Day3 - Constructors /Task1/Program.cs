using System;
using System.Security.AccessControl;
using ClassWork;

#region Program Entry Point

/// <summary>
/// Program class demonstrating object creation,
/// property assignment, and method invocation
/// using different initialization approaches.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Application execution starts here.
    /// Demonstrates normal object initialization
    /// and object initializer syntax.
    /// </summary>
    public static void Main(string[] args)
    {
        var obj = new Student();
        obj.name = "hello";
        obj.rollNo = 1;
        obj.marks = 30;
        obj.greet();

        var obj1 = new Student()
        {
            name = "hello3",
            rollNo = 2,
            marks = 45
        };
    }

    #endregion
}

#endregion
