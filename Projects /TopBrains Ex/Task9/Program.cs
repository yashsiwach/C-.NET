public class Program
{
    public static void Main(string[] args)
    {
        string? word1=Console.ReadLine();
        string? word2= Console.ReadLine();
        if (word1 == null || word2 == null)
            return;
        for(int i = word1.Length-1; i >= 0; i--)
        {
            // Condition 1:
            // Character is NOT a vowel and exists in word2 (case-insensitive)
            // OR
            // Condition 2:
            // Current character is same as previous character (case-insensitive)
            if ((!"aeiouAEIOU".Contains( word1[i])&&word2.ToLower().Contains(char.ToLower(word1[i])))||(i > 0 && char.ToLower(word1[i]) == char.ToLower(word1[i - 1])))
            {
                word1=word1.Remove(i,1);
            }
            
        }
        System.Console.WriteLine(word1);
        
    }
}