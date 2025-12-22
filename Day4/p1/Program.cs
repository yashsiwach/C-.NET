using System;
using Classwork.Ctor;
/// <summary>
/// Main entry point
/// </summary>
public class Program
{
    public static void Main(String [] args)
    {

        A obj=new A();
        try{
        A obj1=new A("test");
        }
        catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        
        A obj2=new A("test1","done");
        A obj3=new A(2,3);

        System.Console.WriteLine(obj.name +" "+ obj.surname);
       // System.Console.WriteLine(obj1.name +" "+ obj1.surname);
        System.Console.WriteLine(obj2.name +" "+ obj2.surname);
       


    }
}
