using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

public class IndexModel : PageModel
{
    [BindProperty] 
    public string? Code { get; set; }
    public string? Output { get; set; }

    private const string FilePath = "/home/linux/Documents/GitHub/C-.NET/Projects /Web/CodeTest/";
    private const string ProjectPath = "/home/linux/Documents/GitHub/C-.NET/Projects /Web/";

    public void OnGet() => Code = "using System;\nclass Test {\nstatic void Main(){\nConsole.WriteLine(\"Hello\");\n}\n}";

    public void OnPost()
    {
        System.IO.File.WriteAllText(FilePath, Code);
        
        var p = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = $"-c \"dotnet run --project {ProjectPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            }
        };
        
        p.Start();
        var (output, error) = (p.StandardOutput.ReadToEnd(), p.StandardError.ReadToEnd());
        p.WaitForExit();
        
        Output = string.IsNullOrWhiteSpace(error) ? output : error;
    }
}
