using System.Collections;

namespace Project1.Model
{
    /// <summary>
    /// This class is used to create and schedule an exam
    /// </summary>
    public class Exam : Examiner
    {
        #region Member Variables

        /// <summary>
        /// Stores unique exam id
        /// </summary>
        public int examId;

        /// <summary>
        /// Stores name of the exam
        /// </summary>
        public string? examName;

        /// <summary>
        /// Stores exam date
        /// </summary>
        public string? examDate;

        /// <summary>
        /// Stores exam room number
        /// </summary>
        public int examRoom;

        #endregion

        #region Class Methods

        /// <summary>
        /// Default constructor that automatically schedules the exam
        /// </summary>
        public Exam()
        {
            Schedule();
        }

        /// <summary>
        /// Schedules the exam by taking exam date and room number
        /// from the user and assigning them to the object
        /// </summary>
        public void Schedule()
        {
            System.Console.WriteLine("Enter exam date");
            string? examDate = Console.ReadLine();
            this.examDate = examDate;

            System.Console.WriteLine("Enter the room number");
            int examRoom = int.Parse(Console.ReadLine()!);
            this.examRoom = examRoom;
        }

        #endregion
    }
}
