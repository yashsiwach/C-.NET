using Day7;

public class Program
{
    /// <summary>
    /// Entry point of the program demonstrating interface-based behavior.
    /// </summary>
    public static void Main()
    {
        // Accessing swimming behavior through swimming interface reference
        TSwimmingBird sb = new Bird();
        sb.Swimming();

        // Accessing singing behavior through singing interface reference
        ISingingBird ssb = new Bird();
        ssb.Singing();
    }
}
