public class Program
{
    public static void Main()
    {
        // Ask user for input
        System.Console.WriteLine("Enter the sentence");

        // Read input sentence (nullable)
        string? s = Console.ReadLine();

        // Check whether all characters are alphabets OR space
       
        bool check = s.All(x => char.IsLetter(x) || x == ' ');

        // If invalid input, print message and exit
        if (check == false)
        {
            System.Console.WriteLine("invalid INput");
            return;
        }

        // Split sentence into words using space
        string[] words = s.Split(" ");

        // If sentence has exactly two words
        if (words.Length == 2)
        {
            // Reverse the order of words (word positions)
            var ans = words.Reverse();

            // Join reversed words back into a sentence
            string fine = string.Join(" ", ans);

            // Print result
            System.Console.WriteLine(fine);
        }
        else
        {
            // For more than two words
            // Reverse each word individually
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(
                    words[i].ToCharArray()
                             .Reverse()
                             .ToArray()
                );
            }

            // Join modified words back into a sentence
            string fine = string.Join(" ", words);

            // Print result
            System.Console.WriteLine(fine);
        }
    }
}
