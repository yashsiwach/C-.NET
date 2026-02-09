public class Program
{
    public static void PrintReport(string title, int copies = 1, bool showHeader = true)
    {
        System.Console.WriteLine(title+" "+copies+" "+showHeader);
    }
    public static void Main(string[] args)
    {
        PrintReport("test");
        PrintReport("test2",2,false);
        PrintReport(title:"jaat",copies:123);
    }
}