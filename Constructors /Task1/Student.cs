using System;
namespace ClassWork
{
    /// <summary>
    /// Class to manage the student
    /// </summary>
    public class Student
    {
        #region Declaration
        public string name {get; set;}
        public int rollNo {get; set;}
        public int marks {get; set;}
        #endregion

        #region Constructor
        public Student()
        {
            this.name="demo";
            this.rollNo=0;
            this.marks=0;
        }
        #endregion

        /// <summary>
        /// function to Greet 
        /// </summary>
        public void greet()
        {
            System.Console.WriteLine("heelo from "+name);
        }

    }
}