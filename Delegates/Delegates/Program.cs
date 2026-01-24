using System.Security.Cryptography;
using Learn;

public class Program
{
    public static void Main()
    {
        PrintingCompany pc = new PrintingCompany();
        pc.CustomerMessage = new PrintMessage(HappyD);
        pc.Print("dipawali");
        MultiDelegates md = new MultiDelegates();
        md.Show();

    }
    private static string HappyD(string message)
    {
        return "heelo " + message;
    }


}