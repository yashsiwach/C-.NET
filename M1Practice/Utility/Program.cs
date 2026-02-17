
using System;

public class Program
{
    private static int _tries = 0;                    // Simulation counter

    public static void Main()
    {
        // A function that fails twice, then succeeds
        int result = ExecuteWithRetry(() =>
        {
            _tries++;
            if (_tries <= 2) throw new InvalidOperationException("Temporary failure");
            return 999;
        }, maxAttempts: 3);

        Console.WriteLine(result);                    // Expected: 999
    }

    // ✅ TODO: Students implement only this function
    public static T ExecuteWithRetry<T>(Func<T> work, int maxAttempts)
    {
        if (work == null)
            throw new ArgumentNullException(nameof(work));
        if (maxAttempts <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxAttempts));
        Exception? lastException = null;
        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            try
            {
                return work();
            }
            catch (Exception ex)
            {
                lastException = ex;
                if (attempt == maxAttempts)
                    throw;
            }
        }
        
        throw lastException!;
    }
}