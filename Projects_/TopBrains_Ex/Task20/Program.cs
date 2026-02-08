using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student("A", 20, 90),
            new Student("B", 18, 90),
            new Student("C", 19, 95)
        };

        students.Sort(new StudentComparer());

        foreach (var s in students)
            Console.WriteLine($"{s.Name} {s.Age} {s.Marks}");
    }
}

// Sorts students by highest marks, then by youngest age if marks are equal.
class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int markCompare = y.Marks.CompareTo(x.Marks);
        return markCompare != 0 ? markCompare : x.Age.CompareTo(y.Age);
    }
}

class Student
{
    public string Name;
    public int Age;
    public int Marks;

    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
}
