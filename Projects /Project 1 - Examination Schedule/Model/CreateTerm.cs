using System.Collections;
using System.Threading.Tasks.Dataflow;
using Project1.Databank;
namespace Project1.Model
{
    /// <summary>
    /// This class is used to create a Term and it inherits the Exam class
    /// and implements the TermBase interface
    /// </summary>
    public class CreateTerm : Exam, TermBase
    {
        #region Member Variables

        /// <summary>
        /// Stores term id
        /// </summary>
        public int id;

        /// <summary>
        /// Stores subjects of the term
        /// </summary>
        public string? subjects;

        #endregion

        #region Methods

        /// <summary>
        /// Constructor that creates a term by taking input from the user
        /// and also calls the method to create the exam
        /// </summary>
        public CreateTerm()
        {
            #region Input Taking

            System.Console.WriteLine("Enter the term Id");
            int tid = int.Parse(Console.ReadLine()!);
            this.id = tid;

            System.Console.WriteLine("Enter subjects in one line");
            string? subs = Console.ReadLine();
            this.subjects = subs;

            #endregion

            CreateExam();
        }

        /// <summary>
        /// Creates an exam by taking exam details from the user
        /// and assigning them to the current object
        /// </summary>
        public void CreateExam()
        {
            System.Console.WriteLine("Enter the Exam Id");
            int examId = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Enter the name of exam");
            string? examName = Console.ReadLine();

            this.examId = examId;
            this.examName = examName;

            System.Console.WriteLine("Want to Add more students \n1. yes \n2. no");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Batch bth = new Batch();
                bth.AddMore();
                Data.batchList.Add(bth);
            }
        }

        /// <summary>
        /// Displays the complete details of the created term and exam
        /// </summary>
        public void Show()
        {
            System.Console.WriteLine(
                $"Done you have created {examName} exam of term {id}. " +
                $"Your Exam Id is {examId} take place on {examDate} in room {examRoom}. " +
                $"Your Examiner is {exName}"
            );

            System.Console.WriteLine("Students are :");

            foreach (var i in Data.studentList)
            {
                System.Console.WriteLine(i.sName);
            }
        }

        #endregion
    }
}
