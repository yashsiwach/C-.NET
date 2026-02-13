public class Program
{
    public static void Main(string[] args)
    {
        List<string>serials=new List<string>{"S1","S2","S1","S3","S2","S2"};
        var freq=serials.GroupBy(x=>x).Where(x=>x.Count()>1).ToDictionary(g=>g.Key,g=>g.Count());
        foreach(var i in freq)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }



    }
    
}
