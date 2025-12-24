using System;
namespace Taxs
{
    public abstract class Loginabs
    {
        public abstract void  Login(string username, string password);
        public abstract  void Logout();
        public void Print()
        {
            System.Console.WriteLine("hello");
        }
    }
    public class Auth:Loginabs
    {
        private string? username = "test";
        private string? password ="admin";
        public override void Login(string username, string password)
        {
            if (username.Equals(this.username) && password.Equals(this.password))
            {
                System.Console.WriteLine("login success");
            }
            else
            {
                System.Console.WriteLine("incorrect data");
            }
        }
        public override void Logout()
        {
            System.Console.WriteLine("logout");
        }
        public void See()
        {
            Print();
        }
    }
}