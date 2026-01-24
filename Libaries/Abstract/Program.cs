using System;
using System.Reflection.Metadata;
using Taxation;
using Taxs;
public class Program
{
    /// <summary>
    /// Entry Point
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {
        #region Declaration
        string? input1=Console.ReadLine();
        int salary=int.TryParse(input1,out salary)?salary:0;
        India ind = new India();
        Us us = new Us();
        double taxUs=us.Tax(salary);
        Auth ok=new Auth();
        #endregion



        #region Output
        ok.See();
        ok.Login("test","admin");
        System.Console.WriteLine((taxUs));
        double taxIndia=ind.Tax(salary);
        System.Console.WriteLine((taxIndia));
        #endregion
    }
}