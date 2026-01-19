// This program demonstrates swapping two numbers
// using ref and out parameters without a temporary variable
public class Program
{
    // Swap using ref: directly modifies the original variables
    public static void SwapWithRef(ref int n, ref int m)
    {
        n = n + m;
        m = n - m;
        n = n - m;
    }

    // Swap using out: returns swapped values via output parameters
    public static void SwapWithOut(int a, int b, out int x, out int y)
    {
        x = a + b;
        y = x - b;
        x = x - y;
    }

    public static void Main(string[] args)
    {
        // Initial values
        int n = 3;
        int m = 5;

        // Swap values using ref method
        SwapWithRef(ref n, ref m);
        System.Console.WriteLine(n + " " + m);

        // Swap values using out method
        SwapWithOut(n, m, out n, out m);
        System.Console.WriteLine(n + " " + m);
    }
}
