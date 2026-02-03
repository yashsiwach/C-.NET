public class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Gcd(a, b));

        static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
}