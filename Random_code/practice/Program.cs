using System.Runtime.CompilerServices;

public delegate int Maxi(int a,int b);
public delegate void ktm();
public class Program
{
    public int balance=0;
    public event Action kyaktm;
    public static void Main()
    {
        //Maxi m=new Program().cal;
        //System.Console.WriteLine(m(1,2));
        // Action print=new Program().greet;
        // Action<int>sq=(n)=>{System.Console.WriteLine(n*n);};
        // Func<int,int> f=(n)=>n*n;
        // //sq(2);
        // System.Console.WriteLine( f(2));
        // Maxi m=new Program().cal1;
        // m+=new Program().cal;
        // System.Console.WriteLine(m(2,1));
        Program obj=new Program();
        obj.kyaktm=()=>System.Console.WriteLine("ktm hogya");
        obj.kyaktm+=()=>System.Console.WriteLine("barva le");
        obj.balance-=1;
        if (obj.balance < 0)
        {
            obj.kyaktm?.Invoke();
        }

    }
    public void al()
    {
        System.Console.WriteLine("balance low");
    }
    public int cal(int a,int b)
    {
        return Math.Max(a,b);
    }
     public int cal1(int a,int b)
    {
        return a-b;
    }

    public void greet()
    {
        System.Console.WriteLine("get lost");
    }
}