public class Ticket
{
    public static int TicketNumber=1000;
    public Ticket()
    {
        TicketNumber++;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Ticket t1=new Ticket();
        System.Console.WriteLine(Ticket.TicketNumber);
        Ticket t2=new Ticket();
        System.Console.WriteLine(Ticket.TicketNumber);
    }
}