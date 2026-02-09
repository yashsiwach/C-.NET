public class Person
{
    public string? Name{get;set;}
    public int Age{get;set;}
    public Person(string name,int age)
    {
        Name=name;
        Age=age;
    }
}
public class Student:Person
{
    public int RollNo{get;set;}
    public int Marks{get;set;}
    public Student(int roll,int marks,string name,int age) : base(name, age)
    {
        RollNo=roll;
        if (marks < 35)
        {
            System.Console.WriteLine("fail");
        }
        else
        {
            System.Console.WriteLine("Pass");
            System.Console.WriteLine(name+" "+age+" "+roll);
        }
    }

}

public class Program
{
    public static void Main(String[] args)
    {
        Student student1=new Student(1,65,"test1",23);
        Student student2=new Student(2,30,"test2",23);
    }
}