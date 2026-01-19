public class Program
{
    public static string check(List<string> lis)
    {
        // Expression must have exactly 3 parts: number operator number
        if (lis.Count != 3)
            return "Error:InvalidExpression";

        // Check if first and third values are valid integers
        if (!int.TryParse(lis[0], out int a) || !int.TryParse(lis[2], out int b))
            return "Error:InvalidNumber";

        // Operator should be a single valid character
        if (!char.TryParse(lis[1], out char ch))
            return "Error:UnknownOperator";

        // Check for supported operators
        if (!(ch == '+' || ch == '-' || ch == '*' || ch == '/'))
            return "Error:UnknownOperator";

        // Division by zero check
        if (ch == '/' && b == 0)
            return "Error:DivideByZero";

        return "";
    }

    public static void Main(string[] args)
    {
        // Read input like: "10 + 5"
        string? s = Console.ReadLine();

        // Split input into parts
        var ops = s.Split(" ").ToList();

        // Validate expression
        string result = check(ops);
        if (result.Length > 0)
        {
            System.Console.WriteLine(result);
            return;
        }

        // Safe to parse after validation
        int a = int.Parse(ops[0]);
        int b = int.Parse(ops[2]);

        // Perform operation based on operator
        switch (ops[1])
        {
            case "+":
                result = (a + b).ToString();
                break;
            case "-":
                result = (a - b).ToString();
                break;
            case "*":
                result = (a * b).ToString();
                break;
            case "/":
                result = (a / b).ToString();
                break;
        }

        // Print result
        System.Console.WriteLine(result);
    }
}
