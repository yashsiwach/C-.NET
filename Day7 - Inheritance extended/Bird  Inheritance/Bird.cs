namespace Day7
{
    /// <summary>
    /// Represents a bird that can swim and sing using interface implementations.
    /// </summary>
    public class Bird : ISwimmingBird, ISingingBird
    {
        // Implements swimming behavior of a bird
        void ISwimmingBird.Swimming()
        {
            System.Console.WriteLine("Bird is swimming");
        }

        // Implements singing behavior of a bird
        void ISingingBird.Singing()
        {
            System.Console.WriteLine("Bird is Singing");
        }
    }
}
