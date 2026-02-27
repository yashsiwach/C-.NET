using System;
using System.Collections.Generic;

namespace WebAPICRUD.Models;

public partial class Student
{
    public int Rollno { get; set; }

    public string? Firstname { get; set; }

    public int? Marks { get; set; }
}
