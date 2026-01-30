
public class User
{
    public string? Name{get;set;}
    
}
public class Data
{
    public static List<T>list=new List<T>();
   
}
public class Program
{
    
    public static void Main()
    {
        Data.list<Product>.Add(new Product{Name="prod1"});
        Data.list<Product>.Add(new Product{Name="prod2"});
        Data.list<User>.Add(new User{Name="User1"});
        Data.list<User>.Add(new User{Name="User2"});
        Predicate<Product> productChecker=(x)=>
    }

    public List<T> FilterData<T>(List<T> arr, Predicate<T> predicate)
    {
        return arr.Where(x=>predicate(x)==true).ToList();
    }
}