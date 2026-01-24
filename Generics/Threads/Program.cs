public class Program
{
    public static void Main()
    {
    
        //ThreadStart threadStart=new ThreadStart(odd);
        Thread e=new Thread(even);
        Thread t=new Thread(odd);
        t.Start();
        t.Join();
        e.Start();
        t.Priority=System.Threading.ThreadPriority.Highest;
        System.Console.WriteLine(t.Priority);
        System.Console.WriteLine(Thread.GetCurrentProcessorId());
    }
 public static void even()
    {
        for(int i = 0; i < 10; i += 2)
        {
            Thread.Sleep(100);
            System.Console.Write(i+" ");
        }
    }

    public static void odd()
    {
        for(int i = 1; i < 10; i += 2)
        {
            Thread.Sleep(100);
            System.Console.Write(i+" ");
        }
    }
}