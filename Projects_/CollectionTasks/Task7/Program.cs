// Represents construction estimate details
public class EstimateDetails
{
    // Total area planned for construction
    public float ConstructionArea { get; set; }

    // Total available site area
    public float SiteArea { get; set; }
}

// Custom exception thrown when construction area exceeds site area
public class ConstructionEstimateException : Exception
{
    // Constructor that passes custom message to base Exception class
    public ConstructionEstimateException(string s) : base(s)
    {
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create Program object to call non-static methods
        Program obj = new Program();

        // Valid construction estimate (construction area <= site area)
        var res = obj.ValidateConstructionEstimate((float)450.2, 500);

        // Check if returned object is of type EstimateDetails
        if (res is EstimateDetails)
        {
            System.Console.WriteLine("Approved");
        }

        // Invalid construction estimate (construction area > site area)
        var res1 = obj.ValidateConstructionEstimate(400, 300);
    }

    // Validates whether construction area fits within the site area
    public EstimateDetails ValidateConstructionEstimate(float ConstructionArea, float SiteArea)
    {
        try
        {
            // Check if construction area exceeds site area
            if (ConstructionArea > SiteArea)
            {
                // Throw custom exception when estimate is invalid
                throw new ConstructionEstimateException("Sorry not approved");
            }
        }
        catch (Exception e)
        {
            // Print exception message
            System.Console.WriteLine(e.Message);
        }

        // Return estimate details (even if validation fails)
        return new EstimateDetails
        {
            ConstructionArea = ConstructionArea,
            SiteArea = SiteArea
        };
    }
}
