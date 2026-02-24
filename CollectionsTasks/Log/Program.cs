public class Program
{
    public static void Main(string[] args)
    {
        
        List<string>codes=new List<string>{"E02","E01","E02","E01","E03"};
        var freq=codes.GroupBy(x=>x).ToDictionary(g=>g.Key,g=>g.Count()).OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).First();
        Console.Write(freq.Key);
    }
    
}
