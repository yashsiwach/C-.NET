public class Program
{
    public static void Main(string[] args)
    {
        TimeSpan start=new TimeSpan(8,0,0);
        TimeSpan end=new TimeSpan(10,0,0);
        int count=0;
        Queue<(TimeSpan,string)>q=new Queue<(TimeSpan, string)>();
        q.Enqueue((new TimeSpan(9,23,0),"Regular"));
        q.Enqueue((new TimeSpan(8,23,0),"Regular"));
        q.Enqueue((new TimeSpan(10,23,0),"Regular"));
        q.Enqueue((new TimeSpan(9,23,0),"Extra"));
        while (q.Count > 0)
        {
            var top=q.Peek();
            q.Dequeue();
            if(top.Item2=="Regular"&&top.Item1>=start&&top.Item1<=end)count++;
        }
        Console.WriteLine(count);
    }
}
