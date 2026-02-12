using System.Text.RegularExpressions;
public class Program
{
    public static void Main(string[] args)
    {
        string? email=Console.ReadLine();
        // string? pattern=@"^[a-z]*hackerrank$";
        // string? pattern=@"^A.B.C.D.$";
        // string? pattern=@"^[1-9][0-9]{9}$";
        // string? pattern=@"^[a-zA-Z0-9_.]+@[a-zA-Z]+[.][a-zA-Z]{2,4}$";
        // string? pattern=@"^#([0-9A-F]{3}|[0-9A-F]{6})$";
        // string? pattern=@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|1[0-9]|2[0-9]|3[0-1])$";
        // string? pattern=@"^([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|2[5][0-5]).([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|2[5][0-5]).([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|2[5][0-5]).([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|2[5][0-5])$";
        // string? pattern=@"^(0[0-9]|1[0-9]|2[0-3]):([0-5][0-9])$";
        string? pattern=@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).{8,}$";
        if (Regex.IsMatch(email!, pattern))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
