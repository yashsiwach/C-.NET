public class Program
{
    public static void CalculateResult(int[] marks, out int total, out double avg, out string result)
    {
        result="Pass";
        total=0;
        foreach(var i in marks)
        {
            if (i < 35)
            {
                result="Fail";
            }
            total+=i;
        }
        avg=total/marks.Length;
    }
    public static void Main(string[] args)
    {
        int [] marks={ 50, 60,20};
        int total;
        double avg;
        string result;
        CalculateResult(marks,out total,out avg,out result);
        System.Console.WriteLine(total+" "+avg+" "+result);
    }
}