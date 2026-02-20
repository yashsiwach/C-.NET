public class Program
{
    public static void Main(string[] args)
    {
        string s=Console.ReadLine();
        var arr=s.Split(" ");
        arr.Select(x=>x.Reverse());
        foreach(var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}