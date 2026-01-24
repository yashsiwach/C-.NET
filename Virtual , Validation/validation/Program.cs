using System;
using System.ComponentModel.Design;
using Valid;

#region Program Entry Point

/// <summary>
/// Program class demonstrates reading input from console,
/// assigning values to an object, and triggering
/// property-based validation logic.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Application execution starts here.
    /// Reads inputs, assigns them to Check object,
    /// and prints validated output.
    /// </summary>
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int input1 = int.TryParse(a, out input1) ? input1 : 0;

        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();

        var obj = new Check();
        obj.Id = input1;
        obj.Name = input2;
        obj.Rank = input3;

        System.Console.WriteLine(obj.Name);
    }

    #endregion
}

#endregion
