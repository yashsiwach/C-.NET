using System;
using System.Xml;
/// <summary>
/// Classwork program 1
/// </summary>
namespace ClassWork
{
    /// <summary>
    /// Program to check the number is even or not
    /// </summary>
    public class IsEven
    {
        public void Print()
        {
            #region Variable Declarations
            bool flag = true;
            bool output =true;
            int number = 0 ;
            string? input;
            string?choice;
            char ch;
            #endregion

            #region Output printing
            while (flag)
            {
                input=Console.ReadLine();
                number= int.TryParse(input,out  number) ? number :0;
                output = (number % 2 ==0) ? true : false;
                Console.WriteLine(output);
                Console.WriteLine("want to check more? y/n");
                choice=Console.ReadLine();
                if(string.IsNullOrEmpty(choice))break;
                ch = choice[0];
                if (ch != 'y') flag = false;
            }
            #endregion
        }
    }
}