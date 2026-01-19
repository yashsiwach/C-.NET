using System.Text.Json;

// Record to store student name and score
public record Student(string name, int score);

public class Program
{
    public static void Main(string[] args)
    {
        // Input data in "Name:Score" format
        string[] data = new string[5];
        data[0] = "Test1:59";
        data[1] = "Test2:98";
        data[2] = "Test5:89";
        data[3] = "Test4:53";
        data[4] = "Test3:89";

        // List to store parsed Student records
        List<Student> store = new List<Student>();

        // Convert string data into Student objects
        for(int i = 0; i < 5; i++)
        {
            var p = data[i].Split(":");     // Split name and score
            store.Add(new Student(p[0], int.Parse(p[1]))); // Add to list
        }

        // Minimum score filter
        int minScore = 55;

        // Filter students by minScore,
        // sort by score (descending),
        // then sort by name (ascending),
        // and serialize result to JSON
        string json = JsonSerializer.Serialize(
            store
                .Where(x => x.score >= minScore)
                .OrderByDescending(x => x.score)
                .ThenBy(x => x.name)
        );

        // Print JSON output
        System.Console.WriteLine(json);
    }
}
