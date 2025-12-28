namespace Project1.Model
{
    /// <summary>
    /// This class is used to create Student objects
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Stores student id
        /// </summary>
        public int sId;

        /// <summary>
        /// Stores student name
        /// </summary>
        public string? sName;

        /// <summary>
        /// Parameterized constructor to initialize student details
        /// </summary>
        public Student(int id, string? sName)
        {
            this.sId = id;
            this.sName = sName;
        }
    }
}
