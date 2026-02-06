public class Demo
{
    public int Id{get;set;}
    public string? Name{get;set;}
}

public class Program
{

    public static void Main(string[] args)
    {
        Demo a=new Demo();
        Demo b=new Demo();
        System.Console.WriteLine(a.Equals(b));
        List<Demo>data=new List<Demo>();
        data.Add(new Demo{Id=1,Name="tester1"});
        data.Add(new Demo{Id=2,Name="tester11"});
                data.Add(new Demo{Id=2,Name="tester11"});

        data.Add(new Demo{Id=3,Name="tester34"});
        var temp=data.Average(x=>x.Id);
        var temp1=data.Distinct().ToList();
        temp1.ForEach(x=>System.Console.WriteLine(x.Name+ " "+x.Id));
    }
}