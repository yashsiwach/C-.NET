/// <summary>
/// Interface that defines exam-related operations
/// such as score calculation and result evaluation.
/// </summary>
public interface IExam
{
    /// <summary>
    /// Calculates the final score percentage for the exam.
    /// </summary>
    /// <returns>Score percentage</returns>
    public double calculateScore();

    /// <summary>
    /// Evaluates the exam result based on percentage.
    /// </summary>
    /// <param name="percentage">Calculated score percentage</param>
    /// <returns>Result status (Merit / Pass / Fail)</returns>
    public static string evaluateResult(double percentage)
    {
        if (percentage >= 85)
        {
            return "Merit";
        }
        else if (percentage >= 60 && percentage < 85)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}

/// <summary>
/// Represents an online test implementation of the IExam interface.
/// Handles score calculation based on question type.
/// </summary>
public class OnlineTest : IExam
{
    /// <summary>
    /// Name of the student.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Total number of questions in the exam.
    /// </summary>
    public int Totalquestions { get; set; }

    /// <summary>
    /// Number of correctly answered questions.
    /// </summary>
    public int CorrectAnswers { get; set; }

    /// <summary>
    /// Number of wrongly answered questions.
    /// </summary>
    public int WrongAnswers { get; set; }

    /// <summary>
    /// Type of questions (mcq or coding).
    /// </summary>
    public string questionType { get; set; }

    /// <summary>
    /// Initializes a new OnlineTest object with exam details.
    /// </summary>
    /// <param name="Name">Student name</param>
    /// <param name="Totalquestions">Total questions</param>
    /// <param name="CorrectAnswers">Correct answers</param>
    /// <param name="WrongAnswers">Wrong answers</param>
    /// <param name="questionType">Question type</param>
    public OnlineTest(string Name, int Totalquestions, int CorrectAnswers, int WrongAnswers, string questionType)
    {
        this.Name = Name;
        this.Totalquestions = Totalquestions;
        this.CorrectAnswers = CorrectAnswers;
        this.WrongAnswers = WrongAnswers;
        this.questionType = questionType;
    }

    /// <summary>
    /// Calculates the exam score percentage based on
    /// question type and marking scheme.
    /// </summary>
    /// <returns>Final score percentage</returns>
    public double calculateScore()
    {
        double tot = 0;

        if (questionType == "mcq")
        {
            tot = (CorrectAnswers * 2) - (WrongAnswers * (2 * 0.10));
            return (tot / (Totalquestions * 2)) * 100;
        }
        else if (questionType == "coding")
        {
            tot = (CorrectAnswers * 5) - (WrongAnswers * (5 * 0.10));
            return (tot / (Totalquestions * 5)) * 100;
        }

        return 0;
    }
}

/// <summary>
/// Program execution class.
/// Takes input, processes exam data,
/// and displays score and result.
/// </summary>
public class Program
{
    /// <summary>
    /// Application entry point.
    /// Reads student and exam details,
    /// calculates score, and prints result.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Student Name:");
        string studentName = Console.ReadLine();

        Console.WriteLine("Enter Question Type (MCQ or Coding):");
        string questionType = Console.ReadLine();

        Console.WriteLine("Enter Total Number of Questions:");
        int totalQuestions = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Number of Correct Answers:");
        int correctAnswers = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Number of Wrong Answers:");
        int wrongAnswers = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Exam Details ---");
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Question Type: " + questionType);
        Console.WriteLine("Total Questions: " + totalQuestions);
        Console.WriteLine("Correct Answers: " + correctAnswers);
        Console.WriteLine("Wrong Answers: " + wrongAnswers);

        IExam obj = new OnlineTest(studentName, totalQuestions, correctAnswers, wrongAnswers, questionType);

        double tot = obj.calculateScore();
        string res = IExam.evaluateResult(tot);

        System.Console.WriteLine(tot);
        System.Console.WriteLine(res);
    }
}
