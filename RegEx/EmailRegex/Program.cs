using System.Text.RegularExpressions;
public class Program
{
    public static void Main(string[] args)
    {
        string email=Console.ReadLine();
        if (Regex.IsMatch(email, @"^[a-zA-Z0-9.#]+@[a-z]+.com.+$"))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
