/// <summary>
/// Entry point of the program.
/// Reads a number and a limit, generates the multiplication table
/// of the given number up to the specified limit, and prints it.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Read the number whose table is needed
        int n = int.Parse(Console.ReadLine()!);

        // Read how many multiples to generate
        int upto = int.Parse(Console.ReadLine()!);

        // Array to store the results
        int[] ans = new int[upto];

        // Calculate multiples of n
        for(int i = 1; i <= upto; i++)
        {
            ans[i - 1] = n * i;
        }

        // Print the multiplication table
        for(int i = 0; i < upto; i++)
        {
            Console.Write(ans[i] + " ");
        }
    }
}

