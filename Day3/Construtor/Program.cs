using System;

using Con;
public class Program
{
    public static void Main(String[] args)
    {
        //A obj= new A();   this is blocked
        A obj1= new A("test");
        System.Console.WriteLine(obj1.name);
    }
}