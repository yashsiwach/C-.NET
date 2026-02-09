public class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}
    public double Salary{get;set;}
    public Employee(int id,string name,string email,double salary)
    {
        this.Id=id;
        this.Name=name;
        if (salary <= 0)
        {
            salary=30000;
        }
        else
        {
            Salary=salary;
        }
        if (!email.Contains("@"))
        {
            Email="unknown@company.com";
        }
        else
        {
            Email=email;
        }
    }

}
public class Program
{
    
    public static void Main(string[] args)
    {
        Employee employee1=new Employee(1,"test1","tester@mail.com",1200);
        Employee employee2=new Employee(2,"test2","testermail.com",1200);
        Employee employee3=new Employee(3,"test3","tester2@mail.com",1234);

        System.Console.WriteLine(employee1.Id+" "+employee1.Name+" "+employee1.Email+" "+employee1.Salary);
        System.Console.WriteLine(employee2.Id+" "+employee2.Name+" "+employee2.Email+" "+employee2.Salary);
        System.Console.WriteLine(employee3.Id+" "+employee3.Name+" "+employee3.Email+" "+employee3.Salary);

    }
}