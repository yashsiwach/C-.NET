public class Program
{
    public static void Main()
    {
        // string s="yash";
        // File.WriteAllText("text.txt",s);
        using(StreamWriter sw=new StreamWriter("test.txt"))
        {
            sw.WriteLine("hellobaby");
            sw.WriteLine("ok done");
        }
        using(StreamReader sr=new StreamReader("test.txt"))
        {
            string temp="";
            while ((temp=sr.ReadLine()) != null)
            {
            
                System.Console.WriteLine(temp);
            }
        }
        File.Delete("test.txt");
    }
}