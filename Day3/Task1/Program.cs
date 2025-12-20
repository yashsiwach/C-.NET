using System;
using System.Security.AccessControl;
using ClassWork;
public class Program
{
    public static void Main(String[] args)
    {
        var obj = new Student();
        obj.name = "hello";
        obj.rollNo = 1;
        obj.marks = 30;
        obj.greet();

        var obj1= new Student()
        {
            name = "hello3",
            rollNo=2,
            marks=45
        };


    }
}
