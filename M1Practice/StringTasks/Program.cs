using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        string removed=Regex.Replace("15.7abc","[a-z]","");
        Console.WriteLine(removed);
        //hex to int
        string hex="0xFF";
        Console.WriteLine(Convert.ToInt32(hex,16));
        //num to hex
        int a=255;
        Console.WriteLine(a.ToString("X"));

        string[] sci="3E+3".Split('E');
        int first=int.Parse(sci[0]);
        int second=int.Parse(sci[1]);
        Console.WriteLine(first*Math.Pow(10,second));

        string number="2.12.14";
        if(double.TryParse(number,out double test))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        string output=Regex.Replace("$1,500.75","[^0-9.]","");
        Console.WriteLine(output);

    
        Console.WriteLine(Convert.ToInt32("1011",2));

        string two="2,000 apples and 3,500 oranges";
        two=two.Replace(",","");
        string[] splited=two.Split(" ");
        int sum=0;
        foreach(var i in splited)
        {
            if(int.TryParse(i,out int num))
            {
                sum+=num;
            }
            
        }
        Console.WriteLine(sum);

    }
}