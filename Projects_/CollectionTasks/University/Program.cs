using System;
using System.Collections.Generic;

public interface IStudent
{
    int StudentId { get; }
    string Name { get; }
    int Semester { get; }
}

public interface ICourse
{
    
    string CourseCode { get; }
    string Title { get; }
    int MaxCapacity { get; }
    int Credits { get; }
}

public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<TCourse, List<TStudent>> _enrollments = new();

    public bool EnrollStudent(TStudent student, TCourse course)
    {
        if (!_enrollments.ContainsKey(course))
            _enrollments[course] = new List<TStudent>();

        if (_enrollments[course].Count >= course.MaxCapacity)
            return false;

        if (_enrollments[course].Contains(student))
            return false;

        if (course is LabCourse lc && student.Semester < lc.RequiredSemester)
            return false;

        _enrollments[course].Add(student);
        return true;
    }

    public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
    {
        if (!_enrollments.ContainsKey(course))
            return new List<TStudent>().AsReadOnly();

        return _enrollments[course].AsReadOnly();
    }

    public IEnumerable<TCourse> GetStudentCourses(TStudent student)
    {
        List<TCourse> list = new();

        foreach (var i in _enrollments)
        {
            foreach (var j in i.Value)
            {
                if (j.Equals(student))
                {
                    list.Add(i.Key);
                    break;
                }
            }
        }
        return list;
    }

    public int CalculateStudentWorkload(TStudent student)
    {
        int sum = 0;

        foreach (var i in _enrollments)
        {
            foreach (var j in i.Value)
            {
                if (j.Equals(student))
                {
                    sum += i.Key.Credits;
                    break;
                }
            }
        }
        return sum;
    }
}

public class EngineeringStudent : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string Specialization { get; set; }
}

public class LabCourse : ICourse
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int MaxCapacity { get; set; }
    public int Credits { get; set; }
    public string LabEquipment { get; set; }
    public int RequiredSemester { get; set; }
}

public class GradeBook<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<(TStudent, TCourse), double> _grades = new();

    public void AddGrade(TStudent student, TCourse course, double grade)
    {
        if (grade < 0 || grade > 100) return;
        _grades[(student, course)] = grade;
    }

    public double? CalculateGPA(TStudent student)
    {
        double total = 0;
        int credits = 0;

        foreach (var i in _grades)
        {
            if (i.Key.Item1.Equals(student))
            {
                total += i.Value * i.Key.Item2.Credits;
                credits += i.Key.Item2.Credits;
            }
        }

        if (credits == 0) return null;
        return total / credits;
    }

    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        TStudent bestStudent = default;
        double bestGrade = -1;

        foreach (var i in _grades)
        {
            if (i.Key.Item2.Equals(course) && i.Value > bestGrade)
            {
                bestGrade = i.Value;
                bestStudent = i.Key.Item1;
            }
        }

        if (bestGrade == -1) return null;
        return (bestStudent, bestGrade);
    }
}

public class Program
{
    public static void Main()
    {
        var s1 = new EngineeringStudent { StudentId = 1, Name = "A", Semester = 3 };
        var s2 = new EngineeringStudent { StudentId = 2, Name = "B", Semester = 2 };
        var s3 = new EngineeringStudent { StudentId = 3, Name = "C", Semester = 5 };

        var c1 = new LabCourse
        {
            CourseCode = "L101",
            Title = "Physics Lab",
            Credits = 4,
            MaxCapacity = 2,
            RequiredSemester = 3
        };

        var c2 = new LabCourse
        {
            CourseCode = "L102",
            Title = "Advanced Lab",
            Credits = 3,
            MaxCapacity = 1,
            RequiredSemester = 5
        };

        var enrollment = new EnrollmentSystem<EngineeringStudent, LabCourse>();

        Console.WriteLine(enrollment.EnrollStudent(s1, c1));
        Console.WriteLine(enrollment.EnrollStudent(s2, c1));
        Console.WriteLine(enrollment.EnrollStudent(s3, c1));
        Console.WriteLine(enrollment.EnrollStudent(s3, c2));
        Console.WriteLine(enrollment.EnrollStudent(s1, c2));

        var gradeBook = new GradeBook<EngineeringStudent, LabCourse>();

        gradeBook.AddGrade(s1, c1, 80);
        gradeBook.AddGrade(s3, c1, 95);
        gradeBook.AddGrade(s3, c2, 85);

        Console.WriteLine(gradeBook.CalculateGPA(s3));

        var top = gradeBook.GetTopStudent(c1);
        if (top.HasValue)
            Console.WriteLine(top.Value.student.Name + " " + top.Value.grade);
    }
}