using System;
using System.Collections;
using System.Dynamic;
namespace Data
{
    public class Student
    {
        public int id {get; set;}
        public string name{get;set;}
        public ArrayList subjects { get; set; } = new ArrayList();
        public Student()
        {
            this.id=1;
            this.name="demo";
        }

    }
}