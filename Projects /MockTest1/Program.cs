using Mock1;
public class Program
{
    public static void Main()
    {
        Dictionary<int,string> dict=new Dictionary<int, string>();
        dict[1]="test1";
        dict[2]="test2";
        dict[3]="test3";
        System.Console.WriteLine("enter the roll number");
        int roll=int.Parse(Console.ReadLine());
        if (dict.ContainsKey(roll))
        {
            System.Console.WriteLine(dict[roll]);
        }
        else
        {
            System.Console.WriteLine("student  not found");
        }

    }
}