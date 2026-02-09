public class Program
{
    public static void Main(string[] args)
    {
        string? password=Console.ReadLine();
        int len=password.Length;
        if (len < 3)
        {
            System.Console.WriteLine(password);
        }
        else{
            string mid=new string('*',len-2);
        System.Console.WriteLine(password[0]+mid+password[len-1]);
        }
    }
}