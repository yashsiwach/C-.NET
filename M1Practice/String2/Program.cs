using System.Collections;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        string s=Console.ReadLine();
       StringBuilder sb=new StringBuilder();
       sb.Append(s[0]);
       for(int i = 1; i < s.Length; i++)
        {
            if (sb[sb.Length-1] != s[i])
            {
                sb.Append(s[i]);
            }
        }
        var ans=sb.ToString();
        foreach(var i in ans)
        {
            Console.Write(i);
        }
    }
}


