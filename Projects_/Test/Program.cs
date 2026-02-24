using System;
using System.Collections.Generic;

public class person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int marks { get; set; }
}

// public class Compro : IComparer<int>
// {
//     public int Compare(int a , int b)
//     {
//         if(a.Key==b.Key)return a.Value-b.Value;
//         else return b.Key-a.Key;
//     }
// }

public class Program
{
    public static void Main()
    {
        // List<person> lis = new List<person>
        // {
        //     new person { Name="yash", Age=40, marks=23 },
        //     new person { Name="test", Age=22, marks=34 },
        //     new person { Name="gafda", Age=23, marks=67 }
        // };

        // lis.Sort(new Compro());

        // lis.ForEach(x => Console.WriteLine(x.Name));
        SortedDictionary<int,int>dict=new SortedDictionary<int,int>();
        dict[1]=5;
        dict[2]=2;
        dict[3]=1;
        dict[2]=5;
        var t=dict.ToDictionary(x=>x.Key,x=>x.Value);
    }

}