public class Program
{
    public static void Main()
    {
        List<int>data=new List<int>{1,2,3,2};
        HashSet<int>hs=new HashSet<int>(data);
        foreach(var i in hs)
        {
            Console.WriteLine(i);
        }

    }
}