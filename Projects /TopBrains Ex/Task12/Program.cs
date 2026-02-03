public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, -3, 4, 0, 5 };
        int sum = 0;
        foreach (int num in nums)
        {
            if (num == 0) break;
            if (num > 0) sum += num;
        }
        Console.WriteLine(sum);
    
    }
}