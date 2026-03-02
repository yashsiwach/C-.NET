using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Message
{
    public int Id { get; set; }

    [Required]
    public string SenderId { get; set; }

    [Required]
    public string ReceiverId { get; set; }

    [Required]
    public string Text { get; set; }

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public int ConversationId { get; set; }

    [ForeignKey("ConversationId")]
    public Conversation Conversation { get; set; }
}