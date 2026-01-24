

using Microsoft.VisualBasic;

public class TwoGen<T, K>where T:notnull
{
    public static Dictionary<T,K>dict=new Dictionary<T, K>();
    public static void Add(T tk,K tv)
    {
        dict[tk]=tv;
    }
    public static void Show()
    {
        foreach (var i in dict)
        {
            System.Console.WriteLine(i.Key+" "+i.Value);
        }
    }
}

public class Program
{
    public static void Main()
    {
        // TwoGen<int,string> obj=new TwoGen<int, string>();
        // obj.Add(1,"yash");
        // obj.Add(2,"test");
        // obj.Show();
        TwoGen<int,string>.Add(1,"test");
        TwoGen<int,string>.Show();

        //delegate for bool!
        Predicate<int> isEven=number=>number%2==0;
        bool check =isEven(12);
        System.Console.WriteLine(check);

        //delgate  with void to print 
        Action logger ;
        if (DateTime.Now.Hour < 12)
        {
            logger=GoodMorning();
            logger();
        }
        else
        {
            logger=GoodDay();
            logger();
        }
        


        Func<int,int,string> func = (a, b) =>
        {
            return (a+b).ToString();
        };
    }
    public static Action<string> GoodMorning()
    {
        return System.Console.WriteLine("Good Moring "+DateAndTime.Now);
    }
    public static Action<string> GoodDay()
    {
        return System.Console.WriteLine("Day");
    }
}