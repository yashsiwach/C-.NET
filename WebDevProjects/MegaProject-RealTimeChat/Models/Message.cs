using Microsoft.AspNetCore.Identity;

public class Message
{
    public int Id { get; set; }

    public string SenderId { get; set; }
    public IdentityUser Sender { get; set; }

    public string ReceiverId { get; set; }
    public IdentityUser Receiver { get; set; }

    public string Text { get; set; }

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public int ConversationId { get; set; }
    public Conversation Conversation { get; set; }
}