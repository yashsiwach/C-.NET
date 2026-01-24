public class employee
{
    public string Name{get;set;}
    public int Salary{get;set;}
}
public class Program
{

    public static void Main()
    {
        List<employee>data=new List<employee>();
        data.Add(
            new employee
            {
                Name="test",
                Salary=300
            }
        );
        data.Add(
            new employee
            {
                Name="test2",
                Salary=400
            }
        );
        var maxi = data.OrderByDescending(x => x.Salary).First();
        System.Console.WriteLine(maxi.Name);
    }

}