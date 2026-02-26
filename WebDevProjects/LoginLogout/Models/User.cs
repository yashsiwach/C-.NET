using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginLogout.Models;

public partial class User
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string? Gender { get; set; }
    [Required]
    public int? Age { get; set; }
    [Required]
    public string? Email { get; set; }
    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; } = null!;
}
