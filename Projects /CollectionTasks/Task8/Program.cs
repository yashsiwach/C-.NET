public class User
{
    public string? Name{get;set;}
    public string? PhoneNumber{get;set;}
}
public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string s) : base(s)
    {
        
    }
}
public class Program
{
    public static void Main(string[] args){
        Program obj=new Program();
        var res=obj.ValidatePhoneNumber("test1","9658742569");
        if(res is User){
            System.Console.WriteLine("Done");
        }
        var res1=obj.ValidatePhoneNumber("test2","452334252");

    }
    public User ValidatePhoneNumber(string name,string PhoneNumber)
    {
        try
        {
            if (PhoneNumber.Length != 10)
            {
                throw new InvalidPhoneNumberException("Invalid Phone Number");
            }
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        return new User
        {
            Name=name,
            PhoneNumber=PhoneNumber
        };

    }
}