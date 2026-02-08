using Project1.Databank;
/// <summary>
/// Project to schedule the Exam
/// </summary>

namespace Project1.Model
{
    /// <summary>
    /// Batch class is responsible for managing students of an exam
    /// </summary>
    public class Batch
    {
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
                Data.studentList.Add(temp);
                num--;
            }
        }
    }
}
