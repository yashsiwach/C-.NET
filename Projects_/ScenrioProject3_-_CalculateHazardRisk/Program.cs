using ScenrioProject3;

#region Program Entry Point

/// <summary>
/// Program class acts as the entry point
/// for evaluating robot hazard risk by
/// collecting user input and invoking
/// the auditor logic.
/// </summary>
public class Program
{
    #region Main Method

    /// <summary>
    /// Reads input values from the console,
    /// calls the hazard risk calculation,
    /// and displays the final risk score.
    /// </summary>
    public static void Main()
    {
        System.Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
        double armPrecision = double.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Enter Worker Density (1 - 20):");
        int workerDensity = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
        string? machineryState = Console.ReadLine();
        if (machineryState == null)
        {
            Console.WriteLine("Machinery state cannot be null");
            return;
        }

        var obj = new RobotHazardAuditor();
        double Risk = obj.CalculateHazardRisk(armPrecision, workerDensity, machineryState);

        System.Console.WriteLine("Robot Hazard Risk Score: " + Risk);
    }

    #endregion
}

#endregion
