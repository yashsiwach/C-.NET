public class Program
{
    public static void Main(string[] args)
    {
        string input = " llapppptop bag ";
        string trimmed = input.Trim();
        var sb = new System.Text.StringBuilder();

        for (int i = 0; i < trimmed.Length; i++)
        {
            if (i == 0 || trimmed[i] != trimmed[i - 1])
            {
                sb.Append(trimmed[i]);
            }
        }

        string cleaned = sb.ToString().ToLower();
        string result = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(cleaned);
        Console.WriteLine(result);

    }
}
