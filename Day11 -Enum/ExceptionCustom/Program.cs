public class Program
{
    class yashException : Exception
    {
        public override string Message => "change the name yash";
    }
    public static void Main()
    {
        try
        {
            string a = "yash";
            if (a.Equals("yash"))
            {
                throw new yashException();
            }
            else
            {
                System.Console.WriteLine("ok"); ;
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}