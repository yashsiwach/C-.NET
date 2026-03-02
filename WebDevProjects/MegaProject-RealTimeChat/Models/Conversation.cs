using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Conversation
{
    public int Id { get; set; }

    [Required]
    public string User1Id { get; set; }

    [Required]
    public string User2Id { get; set; }
}

//One row per private chat between two users
//No duplicate rows for same pair 