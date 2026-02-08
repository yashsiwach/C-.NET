public class Program
{
    // Checks whether a given number n is a prime number
    public static bool IsPrime(int n)
    {
        // Loop from 2 up to square root of n
        for(int i = 2; i * i <= n; i++)
        {
            // If n is divisible by i, it is not prime
            if(n % i == 0) 
                return false;
        }
        // If no divisors found, n is prime
        return true;
    }

    // Calculates the sum of digits of a given number n
    public static int SumOfDigits(int n)
    {
        int sum = 0;

        // Extract digits one by one until n becomes 0
        while (n > 0)
        {
            int last = n % 10; // Get last digit
            n = n / 10;        // Remove last digit
            sum += last;       // Add digit to sum
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        // Read starting range value
        int m = int.Parse(Console.ReadLine()!);

        // Read ending range value
        int n = int.Parse(Console.ReadLine()!);

        int count = 0; // To store count of valid numbers

        // Iterate through all numbers from m to n
        for(int i = m; i <= n; i++)
        {
            // Check only non-prime numbers
            if (!IsPrime(i))
            {
                // Check condition:
                // sum of digits of (i*i) == (sum of digits of i)^2
                if (SumOfDigits(i * i) == (SumOfDigits(i) * SumOfDigits(i)))
                {
                    count++; // Increment count if condition is satisfied
                }
            }
        }

        // Print final count
        System.Console.WriteLine(count);
    }
}
