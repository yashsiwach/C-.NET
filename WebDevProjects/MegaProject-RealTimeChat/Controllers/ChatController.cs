using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class ChatController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public ChatController(ApplicationDbContext context,UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    public async Task<IActionResult> Private(string id)
    {
        var currentUserId = _userManager.GetUserId(User);
        var receiverId = id;

        var conversation = await _context.Conversations
            .FirstOrDefaultAsync(c =>
                (c.User1Id == currentUserId && c.User2Id == receiverId) ||
                (c.User1Id == receiverId && c.User2Id == currentUserId));

        if (conversation == null)
        {
            conversation = new Conversation
            {
                User1Id = currentUserId,
                User2Id = receiverId
            };

            _context.Conversations.Add(conversation);
            await _context.SaveChangesAsync();
        }

        var messages = await _context.Messages
     .Where(m => m.ConversationId == conversation.Id)
     .Include(m => m.Sender)
     .OrderBy(m => m.SentAt)
     .ToListAsync();

        ViewBag.ReceiverId = receiverId;
        ViewBag.ConversationId = conversation.Id;

        return View(messages);
    }
    [HttpPost]
    public async Task<IActionResult> SendMessage(string receiverId,int conversationId,string text)
    {
        var senderId = _userManager.GetUserId(User);

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

        return RedirectToAction("Private", new { id = receiverId });
    }
}