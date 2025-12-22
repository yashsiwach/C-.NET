using System;
using System.Collections;
using System.Data.Common;
using Data;
public class Program
{
    public static void Main(String[] args)
    {
        ArrayList sub= new ArrayList{"hindi","english"};
        Student obj =new Ug();
        // {
        //     id =2,
        //     name="ram",
        //     subjects=sub
        // };
        obj.id=2;
       obj.name="ram";
        obj.subjects=sub;

        // to acess the child throgh paraent referance explicit coversion of obj
        if(obj is Ug)
        {
            Ug ug=(Ug)obj;
            System.Console.WriteLine($"{ug.study}");
        }
        System.Console.WriteLine(obj.id);
        System.Console.WriteLine(obj.name);
        //System.Console.WriteLine(obj.study);
    }
}