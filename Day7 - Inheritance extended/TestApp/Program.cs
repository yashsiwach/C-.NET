using Test;
public class Program
{
    public static void Main(String[] args)
    {
        System.Console.WriteLine("heelo");
        var obj=new Generic<int>();
        System.Console.WriteLine( obj.Ok(1));
    }
}