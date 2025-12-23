using System;
using System.ComponentModel.DataAnnotations;
namespace Base
{
    /// <summary>
    /// 3 classes to see the use of base and this
    /// </summary>
    public class P
    {
        public void Hello()
        {
            System.Console.WriteLine("hello from Parent");
        }
    }
    /// <summary>
    /// child A from parent P
    /// </summary>
    public class A : P
    {
        public void Hello()
        {
            base.Hello();
            System.Console.WriteLine("hello from A");
        }
    }
    /// <summary>
    /// child B from parent P
    /// </summary>
    public class B : P
    {
        public void Hello()
        {
            base.Hello();
            System.Console.WriteLine("heelo from B");
        }
        public void print()
        {
            this.Hello();
        }
    }
}