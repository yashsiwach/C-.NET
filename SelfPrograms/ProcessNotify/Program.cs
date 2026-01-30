public class Processor<T>
{
    public void ProcessTask<T>(T item,Action<T> action)
    {
        System.Console.WriteLine("Start");
        action(item);
        System.Console.WriteLine("done!");
    }
}
public class Program
{
    public static void Main()
    {
        Processor<string> processor=new Processor<string>();
        Action<string>action=(x)=>System.Console.WriteLine(DateTime.Now+" "+x);
        processor.ProcessTask<string>(" pe order Done! ",action);
    }
   
}
