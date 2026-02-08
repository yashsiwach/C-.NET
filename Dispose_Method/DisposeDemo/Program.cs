public class Program
{
    // Example pattern: a ref struct with Dispose method
    public ref struct TempBuffer
    {
        public void Dispose()
        {
            // cleanup logic (concept)
            System.Console.WriteLine("oik");
        }
    }

    public static void UseBuffer()
    {
        // C# 8.0: using works with ref struct (pattern-based)
        using var buf = new TempBuffer();
        // work with buf
    }
    public static void Main(string[] args)
    {
        UseBuffer();
    }
}