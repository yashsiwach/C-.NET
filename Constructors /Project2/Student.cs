using System;
using System.Collections;
using System.Dynamic;

namespace Data
{
    #region Student Base Class

    /// <summary>
    /// Student class represents a basic student entity
    /// and acts as a base class for other student types.
    /// </summary>
    public class Student
    {
        #region Data Members

        public int id { get; set; }
        public string name { get; set; }
        public ArrayList subjects { get; set; } = new ArrayList();

        #endregion

        #region Constructors

        public Student()
        {
            this.id = 1;
            this.name = "demo";
        }

        #endregion
    }

    #endregion
}
