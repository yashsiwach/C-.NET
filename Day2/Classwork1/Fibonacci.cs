using System;
namespace ClassWork
{
  
    public class Fibonacci
    {
        public void Print()
        {
            string? input1=Console.ReadLine();
            int num;
            num=int.TryParse(input1,out num)?num:0;
            int first= 1;
            int second=1;
            for(int i = 3; i <=num; i++)
            {
                int temp=first+second;
                first=second;
                second=temp;
                System.Console.WriteLine(temp);
            }
        }
    }
}