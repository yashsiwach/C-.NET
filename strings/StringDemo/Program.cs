using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb=new StringBuilder("heelo");
        sb.Append("world");
        System.Console.WriteLine(sb);

        String s=new string('a',10);
        System.Console.WriteLine(s);

        var s1="jaat".ToArray();
        System.Console.WriteLine(s1);
        
        String s2=new string(s1,1,2);
        System.Console.WriteLine(s2);
        string nullString=(string)null;
        System.Console.WriteLine(nullString is string);
        int [] arr= {1,2,3,4,5};
        System.Console.WriteLine(arr.Length+1);
    }
}