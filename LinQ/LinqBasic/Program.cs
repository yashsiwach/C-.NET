using Microsoft.VisualBasic;
using System;
//  public class Student{
//         public string Name { get; set; }
//  }

public class Program
{
    public static bool isPal(string str)
    {
        int i = 0;
        int j = str.Length - 1;
        while (i < j)
        {
            if (str[i] != str[j]) return false;
            i++;
            j--;
        }
        return true;
    
    }Pratik Chavan


   
public static void Main()
{
    // string[] names = { "Ay", "Bdfa", "madam" };
    // var ans = from nam in names where isPal(nam.ToLower()) orderby nam ascending select nam;
    // var ans1 = from nam in names orderby nam select new Student() { Name = nam };
    List<List<int>> marks=new List<List<int>>   
    {
        new List<int>{12,13},
        new List<int>{45,12}
    };
    var data= from mark in marks select new {mark1=mark[0],mark2=mark[1]};
    var avg= (from student in data select student.mark1+student.mark2).Average();
    System.Console.WriteLine(avg);
    // foreach(var i in avg)
    //     {
    //         System.Console.WriteLine(i);
    //     }
    // System.Console.WriteLine);
    // var ans2= from p in System.Diagnostics.Process.GetProcesses() select new Store(){Name=p.ProcessName, Id=p.Id};
    // foreach (var i in ans2)
    //     {
    //         System.Console.WriteLine(i.Name+" "+i.Id);
            
    //     }

    // if (ans != null)
    // {
    //     foreach (var i in ans)
    //     {
    //         System.Console.WriteLine(i);
    //     }
    // }
    // else
    // {
    //     System.Console.WriteLine("not found");
    // }

}
}