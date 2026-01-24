using Del;

/// <summary>
/// Demonstrates delegate usage in C#
/// </summary>
public class Program
{
    /// <summary>
    /// Delegate that references methods taking two integers
    /// and returning an integer
    /// </summary>
    public delegate int DelFunciton(int a, int b);

    /// <summary>
    /// Entry point of the program
    /// </summary>
    public static void Main()
    {
        Program obj = new Program();
        Student obj1 = new Student();

        // Assigning Add1 method to Student delegate
        Student.StuDelegate d1 = obj.Add1;

        // Invoking delegate
        int r1 = d1(5, 3);
        System.Console.WriteLine(r1);

        // Creating delegate instance using another method
        DelFunciton myDel = new DelFunciton(obj.Add2);

        // Invoking delegate
        int result = myDel(1, 2);
        System.Console.WriteLine(result);
    }

    /// <summary>
    /// Adds two numbers and an extra value of 10
    /// </summary>
    public int Add1(int a, int b)
    {
        return a + b + 10;
    }

    /// <summary>
    /// Adds two numbers and an extra value of 20
    /// </summary>
    public int Add2(int a, int b)
    {
        return a + b + 20;
    }
}

namespace Del
{
    /// <summary>
    /// Student class containing its own delegate
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Delegate for student operations
        /// </summary>
        public delegate int StuDelegate(int a, int b);

        /// <summary>
        /// Subtracts two numbers
        /// </summary>
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
