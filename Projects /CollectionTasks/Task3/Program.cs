using System.Runtime.InteropServices;

public class Program
{
    // Static list to store all numbers entered by the user
    public static List<int> NumberList = new List<int>();

    public static void Main(string[] args)
    {
        // Ask user how many numbers they want to enter
        System.Console.WriteLine("Enter the numbers count ");

        // Create Program object to call non-static methods
        Program obj = new Program();

        // Read count of numbers
        int n = int.Parse(Console.ReadLine()!);

        // Loop to read numbers and add them to the list
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine()!);
            obj.AddNumber(temp);
        }

        // Print calculated GPA score
        System.Console.WriteLine(obj.GetGPAScored());

        // Print grade based on given GPA value
        System.Console.WriteLine(obj.GetGradeScored(7));
    }

    // Adds a number to the NumberList
    public void AddNumber(int numbers)
    {
        NumberList.Add(numbers);
    }

    // Calculates GPA score based on stored numbers
    public double GetGPAScored()
    {
        // Multiply each number by 3 and sum them
        var data = NumberList.Select(x => x * 3).Sum();

        // Cast sum to int and store in double
        double res = (int)data;

        // If no numbers exist, return -1
        // Otherwise, calculate GPA
        return NumberList.Count == 0 ? -1 : res / (NumberList.Count * 3);
    }

    // Returns grade character based on GPA value
    public char GetGradeScored(double gpa)
    {
        if (gpa == 10) return 'S';
        else if (gpa >= 9 && gpa < 10) return 'A';
        else if (gpa >= 8 && gpa < 9) return 'B';
        else if (gpa >= 7 && gpa < 8) return 'C';
        else if (gpa >= 6 && gpa < 7) return 'D';
        else if (gpa >= 5 && gpa < 6) return 'E';
        else return '.';
    }
}
