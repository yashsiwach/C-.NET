public interface INotifier
{
    void Send(string message);
}
public class EmailNotifier:INotifier
{
    public void Send(string str)
    {
        System.Console.WriteLine(str+"From Email");
    }
}
public class SmsNotifier:INotifier
{
    public void Send(string str)
    {
        System.Console.WriteLine(str+" From SMS");
    }
}
public class WhatsappNotifier:INotifier
{
    public void Send(string str)
    {
        System.Console.WriteLine(str+"From Whatsapp");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<INotifier> data=new List<INotifier>();
        data.Add(new EmailNotifier());
        data.Add(new SmsNotifier());
        data.Add(new WhatsappNotifier());
        string? message="Hello";
        data.ForEach(x=>x.Send(message));
    }
}