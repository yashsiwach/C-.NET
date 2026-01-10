// Delegate that defines scholarship eligibility criteria
public delegate bool IsEligibleforScholarship(Student std);

// Student class holding student details
public class Student
{
    // Student roll number
    public int RollNo { get; set; }

    // Student name
    public string? Name { get; set; }

    // Student marks
    public int Marks { get; set; }

    // Student sports grade
    public char SportsGrade { get; set; }

    // Returns names of students eligible for scholarship using callback delegate
    public static string GetEligibleStudents(
        List<Student> studentsList,
        IsEligibleforScholarship isEligible)
    {
        string ans = "";

        // Iterate through all students
        foreach (var i in studentsList)
        {
            // Check eligibility using callback method
            if (isEligible(i))
            {
                // Append eligible student name
                ans += i.Name;
                ans += ",";
            }
        }
        return ans;
    }
}

// Program entry point
class Program
{
    public static void Main()
    {
        // List to store students
        List<Student> lstStudents = new List<Student>();

        // Creating student objects
        Student obj1 = new Student()
        {
            RollNo = 1,
            Name = "Raj",
            Marks = 75,
            SportsGrade = 'A'
        };

        Student obj2 = new Student()
        {
            RollNo = 2,
            Name = "Rahul",
            Marks = 82,
            SportsGrade = 'A'
        };

        Student obj3 = new Student()
        {
            RollNo = 3,
            Name = "Kiran",
            Marks = 89,
            SportsGrade = 'B'
        };

        Student obj4 = new Student()
        {
            RollNo = 4,
            Name = "Sunil",
            Marks = 86,
            SportsGrade = 'A'
        };

        // Adding students to the list
        lstStudents.Add(obj1);
        lstStudents.Add(obj2);
        lstStudents.Add(obj3);
        lstStudents.Add(obj4);

        // Get eligible students using callback method
        string? ans = Student.GetEligibleStudents(
            lstStudents,
            ScholarshipEligiblility);

        // Print result with trailing comma
        System.Console.WriteLine(ans);

        // Print result without last comma
        for (int i = 0; i < ans.Length - 1; i++)
        {
            System.Console.Write(ans[i]);
        }
        System.Console.WriteLine();
    }

    // Callback method defining scholarship eligibility logic
    public static bool ScholarshipEligiblility(Student std)
    {
        // Student must have marks > 80 and sports grade A
        if (std.Marks > 80 && std.SportsGrade == 'A')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
