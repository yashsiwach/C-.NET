namespace Learn
{
    public class MultiDelegates
    {
        public delegate void Printer(string m);
        public static void Method1(string m)=>System.Console.WriteLine("a"+m);
        public static void Method2(string m)=>System.Console.WriteLine("b"+m);
        public static void Method3(string m)=>System.Console.WriteLine("c"+m);
        
        public void Show()
        {
            Printer p=Method1;
            p+=Method2;
            p+=Method3;
            p("done");
        }

    }
}