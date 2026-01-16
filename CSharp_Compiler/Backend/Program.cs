using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        string cmd = "dotnet run --project /home/linux/Documents/GitHub/C-.NET/CSharp_Compiler/CodeTest";

        Process p = new Process();
        p.StartInfo.FileName = "/bin/bash";
        p.StartInfo.Arguments = "-c \"" + cmd + "\"";

        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.UseShellExecute = false;

        p.Start();

        string[] input = File.ReadAllLines("input.txt");
        string joinedInput = string.Join("\n", input);

        p.StandardInput.WriteLine(joinedInput);
        p.StandardInput.Close();

        string output = p.StandardOutput.ReadToEnd();
        string error = p.StandardError.ReadToEnd();


        p.WaitForExit();
        var expectedArray=File.ReadAllLines("Expected.txt");
        string expected=string.Join("\n",expectedArray);
        if (expected.Trim()==output.Trim())
        {
        File.WriteAllText("output.txt","TestCase 1 Passed");
        }
        else
        {
            File.WriteAllText("output.txt", output + "\n" + error);

        }
    }
}
