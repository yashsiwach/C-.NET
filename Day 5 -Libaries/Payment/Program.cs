using Pay;
public class Program
{
    public static void Main(String[] args)
    {
        Payment p=new Upi(100,"56754");
        p.Pay();
        p.Show();
    }
}