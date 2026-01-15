using System.Collections;

public class MeditationCenter
{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string? Goal { get; set; }
    public double BMI { get; set; }
}

public class Program
{
    public static ArrayList memberList = new ArrayList();

    public static void Main(string[] args)
    {
        Program obj = new Program();

        System.Console.WriteLine("Enter number of members:");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Enter MemberId:");
            int id = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter Weight (kg):");
            double weight = double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter Height (meters):");
            double height = double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter Goal (Weight Gain / Weight Loss):");
            string goal = Console.ReadLine()!;

            obj.AddYogaMember(id, age, weight, height, goal);
        }

        System.Console.WriteLine("Enter MemberId to calculate BMI:");
        int bmiId = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("BMI: " + obj.CalculateBMI(bmiId));

        System.Console.WriteLine("Enter MemberId to calculate Yoga Fee:");
        int feeId = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Yoga Fee: " + obj.CalculateYogaFee(feeId));
    }

    public void AddYogaMember(int MemberId, int Age, double Weight, double Height, string Goal)
    {
        memberList.Add(new MeditationCenter
        {
            MemberId = MemberId,
            Age = Age,
            Weight = Weight,
            Height = Height,
            Goal = Goal
        });
    }

    public double CalculateBMI(int MemberId)
    {
        foreach (MeditationCenter i in memberList)
        {
            if (i.MemberId == MemberId)
            {
                i.BMI = i.Weight / (i.Height * i.Height);
                return Math.Floor(i.BMI);
            }
        }
        return 0;
    }

    public int CalculateYogaFee(int MemberId)
    {
        foreach (MeditationCenter i in memberList)
        {
            if (i.MemberId == MemberId)
            {
                i.BMI = i.Weight / (i.Height * i.Height);

                if (i.Goal == "Weight Gain")
                    return 2500;

                if (i.BMI >= 25 && i.BMI < 30)
                    return 2000;
                else if (i.BMI >= 30 && i.BMI < 35)
                    return 2500;
                else if (i.BMI >= 35)
                    return 3000;
            }
        }
        return 0;
    }
}
