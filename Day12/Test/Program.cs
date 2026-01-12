// public class Parent
// {
//     public void Show()
//     {
//         System.Console.WriteLine("parent");
//     }
// }
// public class Child : Parent
// {
//     public new void Show()
//     {
//         System.Console.WriteLine("child");
//     }
// 
using System.Security.Cryptography.X509Certificates;

public abstract class test2{
    public void ook()
    {
        System.Console.WriteLine("okkkkkkkkkk");
    }
}
public abstract class Hello:test2
{
    public abstract void Show();
    public void ok()
    {
        System.Console.WriteLine("jaat");
    }
}
public class Test:Hello
{
     public override void Show()
    {
        System.Console.WriteLine("overide");
    }

}
public sealed class sclass : Hello
{
    public override void Show()
    {
        System.Console.WriteLine("hogya");
    }
}
public abstract class Program
{
    public static void Main()
    {
        //method hiding using new 
        // Parent obj=new Child();
        // ((Child)obj).Show();

        //anoynomus types
        // var obj =new
        // {
        //     Name="yash",
        //     Roll=12
        // };
        // System.Console.WriteLine(obj.Name);
        
        //abstract class
        Test obj=new Test();
        obj.Show();
        //obj.ok();
        obj.ook();

        var obj2=new sclass();
        obj2.Show();
    
    }
   
}