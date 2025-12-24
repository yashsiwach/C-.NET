namespace Project1
{
    /// <summary>
    /// This class Create the Term  and inherit the Exam class and Termbase interface
    /// </summary>

    public class CreateTerm : Exam,TermBase
    {
        #region Member Variables
        public int id;
        public String? subjects;
        #endregion

        #region Methods
        /// <summary>
        /// Method to create the Term and Call the Function to make the exam too!!
        /// </summary>
        public CreateTerm()
        {
            #region Input Taking
            System.Console.WriteLine("Enter the term Id");
            int tid = int.Parse(Console.ReadLine()!);
            this.id = tid;
            System.Console.WriteLine(" Enter subjects in one line");
            string? subs = Console.ReadLine();
            this.subjects = subs;
            #endregion
            
            CreateExam();
        }
        /// <summary>
        /// Creates an exam by taking exam details from the user and assigning
        /// them to the current object.
        /// </summary>
        /// <remarks>
        /// This method prompts the user to enter the exam ID and exam name,
        /// reads the input from the console, and stores the values in the
        /// corresponding class-level variables.
        /// </remarks>
        /// <variables>
        /// examId    : Stores the unique identifier of the exam entered by the user.
        /// examName  : Stores the name of the exam entered by the user.
        /// </variables>        
            
        public void CreateExam()
        {
            
            System.Console.WriteLine("Enter the Exam Id");
            int examId = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Enter the name of exam");
            string? examName = Console.ReadLine();
            this.examId=examId;
            this.examName=examName;

        }
        /// <summary>
        /// Displays the complete details of the created exam and its associated term.
        /// </summary>
        /// <remarks>
        /// This method prints a summary including the exam name, term ID, exam ID,
        /// scheduled date, room number, and the assigned examiner name.
        /// </remarks>
        /// <variables>
        /// examName  : Name of the exam.
        /// id        : Term identifier.
        /// examId    : Unique exam identifier.
        /// examDate  : Scheduled date of the exam.
        /// examRoom  : Room number where the exam will take place.
        /// exName    : Name of the assigned examiner.
        /// </variables>
        public void Show()
        {
            System.Console.WriteLine($"Done you have created {examName} exam of term {id}.Your Exam Id is {examId} take place on {examDate} in room {examRoom}.Your Examinar is {exName}");

        }
        #endregion
    }
}