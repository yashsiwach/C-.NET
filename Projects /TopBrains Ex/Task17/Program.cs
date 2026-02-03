using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] employees = { "H 100 8", "S 50000", "C 10000 30000" };
        Console.WriteLine(TotalPayroll(employees));
    }

    // Summary: Calculates total payroll using inheritance and polymorphism.
    static decimal TotalPayroll(string[] employees)
    {
        decimal total = 0;

        foreach (var e in employees)
            total += CreateEmployee(e)?.Pay() ?? 0;

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    static Employee CreateEmployee(string s)
    {
        var p = s.Split(' ');
        return p[0] switch
        {
            "H" => new Hourly(decimal.Parse(p[1]), decimal.Parse(p[2])),
            "S" => new Salaried(decimal.Parse(p[1])),
            "C" => new Commission(decimal.Parse(p[1]), decimal.Parse(p[2])),
            _ => null
        };
    }
}

abstract class Employee { public abstract decimal Pay(); }

class Hourly : Employee
{
    decimal r, h;
    public Hourly(decimal r, decimal h) { this.r = r; this.h = h; }
    public override decimal Pay() => r * h;
}

class Salaried : Employee
{
    decimal s;
    public Salaried(decimal s) { this.s = s; }
    public override decimal Pay() => s;
}

class Commission : Employee
{
    decimal c, b;
    public Commission(decimal c, decimal b) { this.c = c; this.b = b; }
    public override decimal Pay() => b + c;
}
