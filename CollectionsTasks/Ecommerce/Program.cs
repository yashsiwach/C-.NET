public class Program
{
    public static void Main(string[] args)
    {
        List<(string ,int )>scans=new();
        scans.Add(("A101",2));
        scans.Add(("B205",1));
        scans.Add(("A101",3));
        scans.Add(("C423",-1));
        var result=scans.GroupBy(x=>x.Item1).ToDictionary(g=>g.Key,g=>g.ToList().Sum(y=>y.Item2));
        foreach(var i in result)
        {
            if(i.Value>0)
            Console.WriteLine(i.Key+" "+i.Value);
        }
    }
}