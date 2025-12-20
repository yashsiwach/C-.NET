using System;
using Game;
using System.Collections;
using System.Runtime.InteropServices;
public class Program
{
    public static void Main(String[] args)
    {
        int n=int.Parse(Console.ReadLine());
        Employee [] data=new Employee[n];
        int id;
        string name;
        bool isPlaying;
        int projectsDone;
        int timeTaken;
        for(int i = 0; i < n; i++)
        {
            id=int.Parse(Console.ReadLine());
            name = Console.ReadLine();
            isPlaying=bool.Parse(Console.ReadLine());
            projectsDone=int.Parse(Console.ReadLine());
            timeTaken=int.Parse(Console.ReadLine());
            Employee obj=new Employee(id,name,isPlaying,projectsDone,timeTaken);
            data[i]=obj;
        }
        
        Result result = new Result();
        result.Playing(data, n);
    }
}