using System.Collections;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);
        int counter = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (sb[sb.Length - 1] != s[i])
            {
                if (counter > 1)
                {

                    sb.Append(counter.ToString());
                    counter = 1;
                }
                sb.Append(s[i]);
            }
            else
            {
                counter++;
            }
        }
        if (counter > 1)
        {

            sb.Append(counter.ToString());
            counter = 1;
        }
        var ans = sb.ToString();
        foreach (var i in ans)
        {
            Console.Write(i);
        }
    }
}


