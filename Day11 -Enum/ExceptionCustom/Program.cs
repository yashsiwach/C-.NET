public class Program
{
    public class yashException : Exception
    {
        public override string Message => Handlebase(base.Message);
        private string Handlebase(string sysMsg)
        {
            System.Console.WriteLine(sysMsg);
            return "ok "+sysMsg;
        }
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