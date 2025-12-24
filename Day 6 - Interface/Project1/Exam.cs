namespace Project1
{
    /// <summary>
    /// This is the class to Create the exam
    /// </summary>
    public class Exam : Examiner
    {
        #region Member Variables
        public int examId;
        public string? examName;
        public string? examDate;
        public int examRoom;
        #endregion

        #region Class Methods
        public Exam()
        {
            Schedule();
        }
        /// <summary>
        /// Schedules the exam by collecting the exam date and room number
        /// from the user and storing them in the object.
        /// </summary>
        /// <variables>
        /// examDate  : Date on which the exam is scheduled.
        /// examRoom  : Room number where the exam will be conducted.
        /// </variables>
        public void Schedule()
        {
            System.Console.WriteLine("Enter  the date");
            string? examDate = Console.ReadLine();
            this.examDate = examDate;

            System.Console.WriteLine("Enter the room number");
            int examRoom = int.Parse(Console.ReadLine()!);
            this.examRoom = examRoom;
        }
        #endregion


    }
}