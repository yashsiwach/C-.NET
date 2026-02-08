using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> res = new Dictionary<string, string>();

        var obj = Program.studentDetails.FirstOrDefault(x => x.Value.Id == id);

        if (obj.Equals(default(KeyValuePair<int, Student>)))
        {
            return res;
        }

        string value = obj.Value.Name + "_" + obj.Value.Course;
        res[id] = value;
        return res;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Student> res = new Dictionary<string, Student>();

        var obj = Program.studentDetails.FirstOrDefault(x => x.Value.Id == id);

        if (obj.Equals(default(KeyValuePair<int, Student>)))
        {
            return res;
        }

        obj.Value.Marks = marks;
        res[id] = obj.Value;
        return res;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails = new Dictionary<int, Student>();

    public static void Main(string[] args)
    {
        studentDetails.Add(1, new Student { Id = "S1", Name = "Aman", Course = "CSE", Marks = 80 });
        studentDetails.Add(2, new Student { Id = "S2", Name = "Ravi", Course = "ECE", Marks = 75 });
        studentDetails.Add(3, new Student { Id = "S3", Name = "Neha", Course = "IT", Marks = 85 });

        int choice = 0;
        StudentUtility util = new StudentUtility();

        while (choice != 3)
        {
            Console.WriteLine("\n1 -> Get student details");
            Console.WriteLine("2 -> Update marks");
            Console.WriteLine("3 -> Exit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter student id:");
                string id = Console.ReadLine();

                var details = util.GetStudentDetails(id);

                if (details.Count == 0)
                {
                    Console.WriteLine("Student not found");
                }
                else
                {
                    foreach (var it in details)
                    {
                        Console.WriteLine(it.Key + " " + it.Value);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter student id:");
                string id = Console.ReadLine();

                Console.WriteLine("Enter new marks:");
                int marks = int.Parse(Console.ReadLine());

                var result = util.UpdateStudentMarks(id, marks);

                if (result.Count == 0)
                {
                    Console.WriteLine("Update failed");
                }
                else
                {
                    Console.WriteLine("Marks updated");
                    foreach (var it in result)
                    {
                        Console.WriteLine(it.Key + " " + it.Value.Name + " " + it.Value.Marks);
                    }
                }
            }
            else
            {
                Console.WriteLine("Thanks for using");
            }
        }
    }
}