using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> lis = new List<int> { 10, 20, 30, 40, 50 };
        int n = lis.Count;
        int k = 2;

        k = k % n;

        var ans =
            lis.Take(n - k).Reverse().Concat(lis.Skip(n - k).Reverse()).Reverse().ToList();

        foreach (var i in ans)
            Console.Write(i + " ");
    }
}