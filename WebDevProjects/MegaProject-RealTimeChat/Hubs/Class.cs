using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;

public class ChatHub : Hub
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public ChatHub(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task SendMessage(string receiverId, int conversationId, string text)
    {
        var senderId = Context.UserIdentifier;
        var sender = await _userManager.FindByIdAsync(senderId);
        var senderEmail = sender?.Email ?? senderId;

        var message = new Message
        {
            SenderId = senderId,
            ReceiverId = receiverId,
            Text = text,
            ConversationId = conversationId,
            SentAt = DateTime.UtcNow
        };

        _context.Messages.Add(message);
        await _context.SaveChangesAsync();

        var sentAt = message.SentAt.ToLocalTime().ToString("dd-MM-yyyy HH:mm:ss");
                await Clients.User(receiverId).SendAsync("ReceiveMessage", senderEmail, text, sentAt);
                await Clients.Caller.SendAsync("ReceiveMessage", senderEmail, text, sentAt);
    }
}
