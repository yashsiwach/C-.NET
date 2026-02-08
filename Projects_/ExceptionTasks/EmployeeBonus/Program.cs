using System;

class BonusCalculator
{
    static void Main()
    {
        int[] salaries = { 5000, 0, 7000 };
        int bonus = 10000;

        foreach (int salary in salaries)
        {
            try
            {
                int result = bonus / salary;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid salary");
            }
        }
    }
}
