using Project1;

/// <summary>
/// Project to schedule the Exam
/// </summary>
namespace Project1
{
    /// <summary>
    /// Batch class is responsible for managing students of an exam
    /// </summary>
    public class Batch
    {
        /// <summary>
        /// Static list that stores all students for the batch
        /// </summary>
        public static List<Student> studentList = new List<Student>();

        /// <summary>
        /// Constructor that initializes the batch with default students
        /// </summary>
        public Batch()
        {
            GetStudents();
        }

        /// <summary>
        /// Adds predefined students to the student list
        /// </summary>
        public void GetStudents()
        {
            Student stu = new Student(1, "demo");
            Student stu2 = new Student(2, "test");
            studentList.Add(stu);
            studentList.Add(stu2);
        }

        /// <summary>
        /// Adds more students to the batch by taking user input
        /// </summary>
        public void AddMore()
        {
            System.Console.WriteLine("How many students you want to add to this exam");
            int num = int.Parse(Console.ReadLine()!);

            while (num > 0)
            {
                System.Console.WriteLine("Enter student id: ");
                int sid = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine("Enter student Name: ");
                string? sname = Console.ReadLine();

                Student temp = new Student(sid, sname);
                studentList.Add(temp);
                num--;
            }
        }
    }
}
