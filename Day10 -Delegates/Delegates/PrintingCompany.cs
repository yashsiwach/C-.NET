using System.Dynamic;

namespace Learn
{
    public delegate string PrintMessage(string message);
    public class PrintingCompany
    {
        public PrintMessage? CustomerMessage{get; set;}
        public void Print(string message)
        {
            string messageToPrint= CustomerMessage(message);
            System.Console.WriteLine(messageToPrint);
        }
    }
}