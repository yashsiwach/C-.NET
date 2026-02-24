public class Program
{
    public static void Main(string[] args)
    {
        List<int>data=new List<int>{10,20,10,30,20,40};
        var result=data.Distinct();
        foreach(var i in result)
        {
            Console.WriteLine(i);
        }
    }
}