using System;
using Game;
using System.Collections;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(String[] args)
    {
        // Read the number of employees from user input
        int n = int.Parse(Console.ReadLine());
        
        // Create an array to store Employee objects
        Employee[] data = new Employee[n];
        
        // Declare variables to store employee data
        int id;
        string name;
        bool isPlaying;
        int projectsDone;
        int timeTaken;
        
        // Loop through to collect data for each employee
        for(int i = 0; i < n; i++)
        {
            // Read employee ID
            id = int.Parse(Console.ReadLine());
            
            // Read employee name
            name = Console.ReadLine();
            
            // Read playing status (true/false)
            isPlaying = bool.Parse(Console.ReadLine());
            
            // Read number of projects completed
            projectsDone = int.Parse(Console.ReadLine());
            
            // Read time taken for projects
            timeTaken = int.Parse(Console.ReadLine());
            
            // Create new Employee object with the collected data
            Employee obj = new Employee(id, name, isPlaying, projectsDone, timeTaken);
            
            // Store the employee object in the array
            data[i] = obj;
        }
        
        // Create a Result object to process the employee data
        Result result = new Result();
        
        // Call the Playing method to process employees who are playing
        result.Playing(data, n);
    }
}
