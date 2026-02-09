using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string? s = "My name is C# Tester";
        var prevtime = DateTime.Now.Millisecond;
        string str = "";
        for (int i = 0; i <= 10000; i++)
        {
            str += s;
        }
        System.Console.WriteLine(prevtime + " " + DateTime.Now.Millisecond);

        StringBuilder sb = new StringBuilder();
        var prevtimesb = DateTime.Now;

        for (int i = 0; i <= 10000; i++)
        {
            sb.AppendLine(s);
        }
        System.Console.WriteLine(prevtimesb.Millisecond + " " + DateTime.Now.Millisecond);
    }
}