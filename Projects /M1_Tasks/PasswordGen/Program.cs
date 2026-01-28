/// <summary>
/// Entry point of the program.
/// Validates a username based on specific rules and
/// generates a TECH code using ASCII values.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method that reads username input,
    /// validates format, and prints generated output.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the usename");

        string? username = Console.ReadLine();

        /// <summary>
        /// Username must be exactly 8 characters long.
        /// </summary>
        if (username.Length != 8)
        {
            System.Console.WriteLine("invalid username must be 8 length");
            return;
        }

        /// <summary>
        /// Extract first 4 characters and check
        /// if all are uppercase alphabets.
        /// </summary>
        string first = username.Substring(0, 4);
        bool isupper = first.All(x => char.IsUpper(x) && char.IsLetter(x));

        if (isupper == false)
        {
            System.Console.WriteLine("First 4 must be uppercase");
            return;
        }

        /// <summary>
        /// Fifth character must be '@'.
        /// </summary>
        if (username[4] != '@')
        {
            System.Console.WriteLine("Fifth must be @");
        }

        /// <summary>
        /// Extract course code and validate numeric range.
        /// </summary>
        string course = username.Substring(5, 3);
        int code = int.Parse(course);

        if (code < 101 && code > 115)
        {
            System.Console.WriteLine("invaild course code");
            return;
        }

        /// <summary>
        /// Convert first 4 characters to lowercase
        /// and calculate ASCII sum.
        /// </summary>
        string first2 = first.ToLower();
        var arr = first2.ToCharArray();

        int asciiSum = 0;
        foreach (var i in arr)
        {
            asciiSum += i;
        }

        /// <summary>
        /// Print final TECH code.
        /// </summary>
        System.Console.WriteLine("TECH_" + asciiSum + course.Substring(1, 2));
    }
}
