using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Represents engagement statistics for a content creator.
/// </summary>
public class CreatorStats
{
    /// <summary>
    /// Name of the creator.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Stores weekly likes for 4 weeks.
    /// </summary>
    public double[] WeeklyLikes { get; set; } = new double[4];
}

/// <summary>
/// Acts as an in-memory store for all creator engagement data.
/// </summary>
public class Store
{
    /// <summary>
    /// Holds the list of registered creators and their stats.
    /// </summary>
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

/// <summary>
/// Entry point and business logic handler for the application.
/// </summary>
public class Program
{
    /// <summary>
    /// Application entry point. Provides a menu-driven interface
    /// to register creators, view top posts, and calculate averages.
    /// </summary>
    public static void Main()
    {
        int count = 0;

        while (count != 4)
        {
            System.Console.WriteLine(
                "1. Register Creator \n2. Show Top Posts \n3. Calculate Average Likes \n4. Exit"
            );

            count = int.Parse(Console.ReadLine()!);

            if (count == 1)
            {
                System.Console.WriteLine("enter user name and 4 weeklylikes!");
                string? name = Console.ReadLine();

                double[] arr = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine()!);
                }

                var obj = new CreatorStats { Name = name, WeeklyLikes = arr };
                var obj1 = new Program();
                obj1.RegisterCreator(obj);

                System.Console.WriteLine("Creator Registered Successfully!");
            }
            else if (count == 2)
            {
                System.Console.WriteLine("enter the like threshold");
                int thresh = int.Parse(Console.ReadLine()!);

                var obj = new Program();
                var toplikes = obj
                    .GetTopPostCounts(Store.EngagementBoard, thresh)
                    .ToList();

                toplikes.ForEach(x =>
                    System.Console.WriteLine(x.Key + " " + x.Value)
                );
            }
            else if (count == 3)
            {
                var obj = new Program();
                System.Console.WriteLine(
                    "Overall average weekly likes: " +
                    obj.CalculateAverageLikes()
                );
            }
        }
    }

    /// <summary>
    /// Registers a creator by adding their statistics
    /// to the engagement board.
    /// </summary>
    public void RegisterCreator(CreatorStats record)
    {
        Store.EngagementBoard.Add(record);
    }

    /// <summary>
    /// Returns the count of weekly posts for creators whose
    /// minimum weekly likes meet the given threshold.
    /// </summary>
    /// <param name="records">List of creator statistics</param>
    /// <param name="likeThreshold">Minimum likes required</param>
    /// <returns>
    /// Dictionary containing creator names and count of qualifying weeks
    /// </returns>
    public Dictionary<string, int> GetTopPostCounts(
        List<CreatorStats> records,
        double likeThreshold
    )
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        var fiter = records
            .Where(x => x.WeeklyLikes.Min() >= likeThreshold)
            .ToList();

        fiter.ForEach(x =>
            dict[x.Name] = x.WeeklyLikes.Count(x => x >= likeThreshold)
        );

        return dict;
    }

    /// <summary>
    /// Calculates the overall average of total weekly likes
    /// across all registered creators.
    /// </summary>
    /// <returns>Average weekly likes</returns>
    public double CalculateAverageLikes()
    {
        var avg = Store.EngagementBoard.Average(
            x => x.WeeklyLikes.Sum()
        );
        return avg;
    }
}
