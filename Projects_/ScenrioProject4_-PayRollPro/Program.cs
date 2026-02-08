using System.Diagnostics.CodeAnalysis;
using ScenrioProject4;
using ScenrioProject4.PayRollPro;

#region Program Class

/// <summary>
/// Program class acts as the entry point
/// for the PayrollPro application.
/// It handles menu navigation and user interaction.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Application execution starts here.
    /// Displays menu options and routes user
    /// actions based on selected choice.
    /// </summary>
    public static void Main()
    {
        int choice = 0;

        while (choice != 4)
        {
            System.Console.WriteLine(
                "1. Register Employee\n" +
                "2. Show Overtime Summary\n" +
                "3. Calculate Average Monthly Pay\n" +
                "4. Exit"
            );

            choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                System.Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract):");
                int tempChoice = int.Parse(Console.ReadLine()!);

                if (tempChoice == 1)
                {
                    System.Console.WriteLine("Enter Employee Name:");
                    string? EmployeeName = Console.ReadLine();

                    System.Console.WriteLine("Enter Hourly Rate:");
                    double HourlyRate = double.Parse(Console.ReadLine()!);

                    System.Console.WriteLine("Enter Monthly Bonus:");
                    double MonthlyBonus = double.Parse(Console.ReadLine()!);

                    System.Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                    double[] arr = new double[4];
                    for (int i = 0; i < 4; i++)
                        arr[i] = double.Parse(Console.ReadLine()!);

                    EmployeeRecord obj =
                        new FullTimeEmployee(EmployeeName, arr, HourlyRate, MonthlyBonus);

                    Program obj1 = new Program();
                    obj1.RegisterEmployee(obj);
                }
                else
                {
                    System.Console.WriteLine("Enter Employee Name:");
                    string? EmployeeName = Console.ReadLine();

                    System.Console.WriteLine("Enter Hourly Rate:");
                    double HourlyRate = double.Parse(Console.ReadLine()!);

                    System.Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                    double[] arr = new double[4];
                    for (int i = 0; i < 4; i++)
                        arr[i] = double.Parse(Console.ReadLine()!);

                    EmployeeRecord obj =
                        new ContractEmployee(EmployeeName, arr, HourlyRate);

                    Program obj1 = new Program();
                    obj1.RegisterEmployee(obj);
                }
            }
            else if (choice == 2)
            {
                System.Console.WriteLine("Enter hours threshold:");
                double hoursThreshold = double.Parse(Console.ReadLine()!);

                Program obj1 = new Program();
                Dictionary<string, int> Overworker =
                    obj1.GetOvertimeWeekCounts(Data.PayrollBoard, hoursThreshold);

                foreach (var i in Overworker)
                {
                    System.Console.WriteLine(i.Key + " " + i.Value);
                }
            }
            else if (choice == 3)
            {
                Program obj = new Program();
                double pay = obj.CalculateAverageMonthlyPay();
                System.Console.WriteLine(pay);
            }
        }
    }

    #endregion

    #region Employee Registration

    /// <summary>
    /// Registers an employee into the payroll board.
    /// </summary>
    public void RegisterEmployee(EmployeeRecord record)
    {
        Data.PayrollBoard.Add(record);
        System.Console.WriteLine("Employee registered successfully");
    }

    #endregion

    #region Payroll Calculations

    /// <summary>
    /// Calculates the average monthly pay
    /// of all registered employees.
    /// </summary>
    public double CalculateAverageMonthlyPay()
    {
        double sum = 0;

        foreach (var rec in Data.PayrollBoard)
        {
            sum += rec.GetMonthlyPay();
        }

        return sum / 4.0;
    }

    /// <summary>
    /// Calculates overtime week counts for employees
    /// based on a given hours threshold.
    /// </summary>
    public Dictionary<string, int> GetOvertimeWeekCounts(
        List<EmployeeRecord> records,
        double hoursThreshold
    )
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var rec in records)
        {
            int hoursWorked = 0;

            foreach (var hour in rec.WeeklyHours)
            {
                if (hour >= hoursThreshold)
                {
                    hoursWorked++;
                }
            }

            dict[rec.EmployeeName] = hoursWorked;
        }

        return dict;
    }

    #endregion
}

#endregion
