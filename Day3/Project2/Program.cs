using System;
using System.Collections;
using Data;
public class Program
{
    public static void Main(String[] args)
    {
        ArrayList sub= new ArrayList{"hindi","english"};
        var obj =new Ug();
        obj.id=2;
        obj.name="ram";
        obj.subjects=sub;
        System.Console.WriteLine(obj.id);
        System.Console.WriteLine(obj.name);
        System.Console.WriteLine(obj.study);
    }
}