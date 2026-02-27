using System;
using System.Collections.Generic;

namespace WebAPICRUD.Models;

public partial class Department
{
    public int DepId { get; set; }

    public string? Manager { get; set; }
}
