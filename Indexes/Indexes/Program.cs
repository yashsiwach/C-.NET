using Indexes;
public class Program
{
    public static void Main()
    {
        // IndexDemo obj=new IndexDemo();
        // obj[0]=45;
        // obj["test"]=100;
        // System.Console.WriteLine(obj[0]);
        // System.Console.WriteLine(obj["test"]);

        var obj = new Student();
        obj.SName="admin";
        obj[0]="test";
        System.Console.WriteLine(obj.SName);
        System.Console.WriteLine(obj[0]);


    }
}