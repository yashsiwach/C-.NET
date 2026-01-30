using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public event Action eve;

    public string? Name { get; set; }
    public int Mark1 { get; set; }
    public int Mark2 { get; set; }
    public int Average { get; set; }

    public Func<int> CalcAverage;

    public Student()
    {
        CalcAverage = () => (Mark1 + Mark2) / 2;
    }

    public void IsFail()
    {
        eve?.Invoke();
    }
}

public class Program
{
    public static List<Student> data = new List<Student>();

    public static void Main(string[] args)
    {
        data.Add(new Student { Name = "test1", Mark1 = 60, Mark2 = 80 });
        data.Add(new Student { Name = "test1", Mark1 = 60, Mark2 = 80 });
        data.Add(new Student { Name = "test2", Mark1 = 70, Mark2 = 90 });
        data.Add(new Student { Name = "test3", Mark1 = 40, Mark2 = 20 });

        var answer = data.Average(x => x.Mark1 + x.Mark2);

        data = data.OrderByDescending(x => x.Mark1 + x.Mark2).ToList();

        Dictionary<int, int> dict = new Dictionary<int, int>();
        int rank = 1;

        foreach (var i in data)
        {
            int avg = (i.Mark1 + i.Mark2) / 2;
            if (!dict.ContainsKey(avg))
            {
                dict[avg] = rank++;
            }
        }

        var notifier = new Student();
        notifier.eve += LowAvg;
        notifier.eve += Reappear;

        Predicate<Student> isFailing = s => s.Average < 50;

        foreach (var x in data)
        {
            x.Average = x.CalcAverage();
            Console.WriteLine(x.Name + " " + x.Average + " Rank: " + dict[x.Average]);

            if (isFailing(x))
            {
                notifier.IsFail();
            }
        }

        Console.WriteLine(answer);

        Action<int> printer = x => Console.WriteLine(x * x);
        Func<int, int, int> adder = (a, b) => a + b;
        Predicate<int> isEven = x => x % 2 == 0;

        printer(2);
        Console.WriteLine(adder(1, 2));
        Console.WriteLine(isEven(3));
    }

    public static void LowAvg()
    {
        Console.WriteLine("Low Avg");
    }

    public static void Reappear()
    {
        Console.WriteLine("Reappear pakki h teri !");
    }
}
