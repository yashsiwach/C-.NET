/// <summary>
/// Main program class that checks string compatibility
/// and calculates edit distance between two inputs.
/// </summary>
public class Program
{
    /// <summary>
    /// Calculates the minimum edit distance (Levenshtein distance)
    /// between two strings using Dynamic Programming.
    /// Operations allowed: insert, delete, replace.
    /// </summary>
    /// <param name="word1">First input string</param>
    /// <param name="word2">Second input string</param>
    /// <returns>Minimum number of operations required</returns>
    public static int MinDistance(string word1, string word2)
    {
        int n = word1.Length;
        int m = word2.Length;

        int[,] dp = new int[n + 1, m + 1];

        dp[0, 0] = 0;

        for (int i = 1; i <= n; i++)
        {
            dp[i, 0] = i;
        }

        for (int i = 1; i <= m; i++)
        {
            dp[0, i] = i;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(
                        dp[i - 1, j],
                        Math.Min(dp[i - 1, j - 1], dp[i, j - 1])
                    );
                }
            }
        }

        return dp[n, m];
    }

    /// <summary>
    /// Program entry point.
    /// Takes two strings as input, checks if one is a subsequence
    /// of the other, and prints compatibility results.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter both names");

        string? s1 = Console.ReadLine();
        string? s2 = Console.ReadLine();

        if (s1 == null || s2 == null)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (s1.Length > s2.Length)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        int i = 0;
        int j = 0;
        int n = s1.Length;
        int m = s2.Length;

        while (i < n && j < m)
        {
            if (s1[i] == s2[j])
            {
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }

        bool isCouple = (i == s1.Length);

        if (isCouple)
        {
            System.Console.WriteLine("made for each other !");
        }
        else
        {
            System.Console.WriteLine("jodi failed");
        }

        System.Console.WriteLine("Compatibility value is : " + MinDistance(s1, s2));
    }
}
