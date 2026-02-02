using System.Drawing;

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string GradeLevel { get; set; }
    public Dictionary<string, double> Subjects = new Dictionary<string, double>();
}
public class SchoolManager
{
    public void AddStudent(string name, string gradeLevel)
    {
        var obj = new Student { StudentID = Program.uniqueID++, Name = name, GradeLevel = gradeLevel };
        Program.Data.Add(obj);
    }
    public void AddGrade(int studentId, string subject, double grade)
    {
        Program.Data.FirstOrDefault(x => x.StudentID == studentId)?.Subjects[subject] = grade;
    }
    public SortedDictionary<string, List<Student>> GroupStudentsByGradeLevel()
    {
        SortedDictionary<string, List<Student>> res = new SortedDictionary<string, List<Student>>();

        var temp = Program.Data.GroupBy(x => x.GradeLevel).ToList();
        foreach (var i in temp)
        {
            res[i.Key] = i.ToList();
        }
        return res;
    }
    public double CalculateStudentAverage(int studentID)
    {
        return Program.Data.FirstOrDefault(x => x.StudentID == studentID).Subjects.Average(x => x.Value);
    }
    public Dictionary<string, double> CalculateSubjectAverages()
    {
        var temp = Program.Data.SelectMany(x => x.Subjects).GroupBy(y => y.Key);
        Dictionary<string, double> res = new Dictionary<string, double>();
        foreach (var i in temp)
        {
            res[i.Key] = i.Average(x => x.Value);
        }
        return res;
        
    }
    public List<Student> GetTopPerformers(int count)
    {
        return Program.Data.OrderByDescending(x => x.Subjects.Average(y => y.Value)).Take(count).ToList();
    }
}

public class Program
{
    public static int uniqueID = 0;
    public static List<Student> Data = new List<Student>();
    public static void Main()
    {
        SchoolManager sm = new SchoolManager();

        sm.AddStudent("Aman", "10");
        sm.AddStudent("Riya", "10");
        sm.AddStudent("Neha", "11");
        sm.AddStudent("Rahul", "11");
        sm.AddStudent("Karan", "12");
        sm.AddStudent("Sneha", "12");

        sm.AddGrade(0, "Math", 85);
        sm.AddGrade(0, "Science", 90);

        sm.AddGrade(1, "Math", 78);
        sm.AddGrade(1, "Science", 88);

        sm.AddGrade(2, "Math", 92);
        sm.AddGrade(2, "Physics", 95);

        sm.AddGrade(3, "Math", 70);
        sm.AddGrade(3, "Physics", 75);

        sm.AddGrade(4, "Math", 88);
        sm.AddGrade(4, "Chemistry", 91);

        sm.AddGrade(5, "Math", 95);
        sm.AddGrade(5, "Chemistry", 93);

        Console.WriteLine("Student Average (ID 2):");
        Console.WriteLine(sm.CalculateStudentAverage(2));

        Console.WriteLine("\nGrouped By Grade Level:");
        var grouped = sm.GroupStudentsByGradeLevel();
        foreach (var g in grouped)
        {
            Console.WriteLine("Grade " + g.Key);
            foreach (var s in g.Value)
                Console.WriteLine(s.Name);
        }

        Console.WriteLine("\nSubject Averages:");
        var subjectAvg = sm.CalculateSubjectAverages();
        foreach (var s in subjectAvg)
            Console.WriteLine(s.Key + " : " + s.Value);

        Console.WriteLine("\nTop 3 Performers:");
        var top = sm.GetTopPerformers(3);
        foreach (var s in top)
            Console.WriteLine(s.Name);
    }

}