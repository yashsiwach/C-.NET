public class Program
{
    public static void Main(string[] args)
    {
        
        List<int>booked=new List<int>{3,5};
        int req=4;
        for(int i = 1; i <= 5; i++)
        {
            if (!booked.Contains(i))
            {
                booked.Add(i);
                req--;
            }
        }
        foreach(var i in booked)Console.Write(i+" ");
        Console.WriteLine();
        Console.WriteLine(req);

    }
    
}


