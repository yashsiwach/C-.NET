using System;
using System.Data;
///Namespace defination
namespace Classwork.Ctor
{
    /// <summary>
    /// class to use polymorphism in the constructors
    /// </summary>
    public class A
    {
        #region Declaration
        public string? name {get;set;}
        public string? surname{get;set;}
        public int a {get; set;}
        public int b
        {
            get {
                return b;
            }
            set
            {
                if (value < 0)
                {
                    b=0;
                }
                else
                {
                    b=value;
                }
            }
        }
        public int c {get;}
        
        #endregion

        #region Methods
        public A()
        {
           System.Console.WriteLine($"default called on { DateTime.Now.ToString() }");
        }
        public A(string name): this()
        {
            System.Console.WriteLine($"name called on { DateTime.Now.ToString() }");
            if (name.ToLower().Contains("test"))
            {
                throw new ArgumentException("give a difff name");
            }
            this.name=name;
            
        }
        public A(string name,string surname):this(name)
        {
            System.Console.WriteLine($"surname called on { DateTime.Now.ToString() }");
            this.surname=surname;
        }


        /// <summary>
        /// to add two numbers
        /// </summary>
        /// <param name="a"> first number</param>
        /// <param name="b">second number</param>
        public A(int a,int b)
        {
            c=a+b;
         
        }
        #endregion
    }
}