public class Program
{
    public static void Main(string[] args)
    {
        string s=Console.ReadLine();
        var arr=s.Split(" ");
        for(int i = 0; i < arr.Length; i++)
        {
            var temp=arr[i].Reverse().ToArray();
            arr[i]=new string(temp);
        }
        foreach(var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

