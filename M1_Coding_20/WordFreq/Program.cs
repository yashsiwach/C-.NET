public class Program
{
    public static void Main(string[] args)
    {
        string? input=Console.ReadLine();
        string[] data=input.Split(" ");
        Dictionary<string,int>dict=new Dictionary<string, int>();
        foreach(var i in data)
        {
            string val=i.ToLower();
            if(dict.ContainsKey(val))dict[val]=dict[val]+1;
            else dict[val]=1;
        }
        foreach(var i in dict)
        {
            System.Console.WriteLine(i.Key+" "+i.Value);
        }

    }
}

