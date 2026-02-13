public class Program
{
    public static void Main(string[] args)
    {
        List<(string,int)>data=new List<(string, int)>{("Raj",80),("Anu",95),("Vikram",95),("Meena",70)};
        int k=3;
        var result=data.OrderByDescending(x=>x.Item2).ThenBy(x=>x.Item1).Take(k);
        foreach(var i in result)
        {
            Console.WriteLine(i.Item1+" "+i.Item2);
        }
    }
}
