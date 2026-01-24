using MathLib;
using ScienceLib;
public class Program
{
    public static void Main()
    {
        Maths a=new Maths();
        int aa=a.add(1,2);
        Science b=new Science();
        int bb=b.Gravity(1,2);
        System.Console.WriteLine(aa+" "+ bb);

    }
}