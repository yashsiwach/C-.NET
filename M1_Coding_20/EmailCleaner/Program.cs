public class Program
{
    public static void Main(string[] args)
    {
        string? email=Console.ReadLine();
        string? trimmed=email.Trim();
        string? lowered=trimmed.ToLower();
        string? replaced=lowered;
        if (lowered.Contains("gmail.com"))
        {
            replaced=lowered.Replace("gmail.com","company.com");   
        }
        System.Console.WriteLine(replaced);
    }
}
