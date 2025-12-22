using System;
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
        public int b {get; set;}
        #endregion

        #region Methods
        public A()
        {
            this.name="demo";
            this.surname="demo";
        }
        public A(string name)
        {
            if (name.ToLower().Contains("test"))
            {
                throw new ArgumentException("give a difff name");
            }
            this.name=name;
            this.surname="demo";
        }
        public A(string name,string surname)
        {
            this.name=name;
            this.surname=surname;
        }
        /// <summary>
        /// to add two numbers
        /// </summary>
        /// <param name="a"> first number</param>
        /// <param name="b">second number</param>
        public A(int a,int b)
        {
            System.Console.WriteLine(a+b);
        }
        #endregion
    }
}