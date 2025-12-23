using System;
using System.ComponentModel.Design;
using Valid;
public class Program
{
    public static void Main(string[] args)
    {
        string a=Console.ReadLine();
        int input1=int.TryParse(a,out input1)?input1:0;
        string input2=Console.ReadLine();
        string input3=Console.ReadLine();
        var obj= new Check();
        obj.Id=input1;
        obj.Name=input2;
        obj.Rank=input3;
        System.Console.WriteLine(obj.Name );
    }
}