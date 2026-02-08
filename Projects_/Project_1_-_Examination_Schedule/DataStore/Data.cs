using System.Threading.Tasks.Dataflow;
using Project1.Model;

namespace Project1.Databank
{
    #region Data Storage Class

    /// <summary>
    /// Static Data class acts as an in-memory datastore
    /// for students and batches.
    /// </summary>
    public static class Data
    {
        #region Data Members

        public static List<Student> studentList = new List<Student>();
        public static List<Batch> batchList = new List<Batch>();

        #endregion

        #region Static Constructor

        /// <summary>
        /// Static constructor initializes
        /// default data for the application.
        /// </summary>
        static Data()
        {
            Student stu = new Student(1, "demo");
            Student stu2 = new Student(2, "test");

            studentList.Add(stu);
            studentList.Add(stu2);
        }

        #endregion
    }

    #endregion
}
