using System;
using System.Runtime.InteropServices;
namespace ClassWork
{
    public class Exce
    {
        public void Print()
        {
            string? input = Console.ReadLine();
            int num=Convert.ToInt16(Console.ReadLine());
            try
            {
                System.Console.WriteLine(input[8]);
                System.Console.WriteLine(num/0);
            }
            catch(DivideByZeroException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("done!");
            }
        }
    }
}