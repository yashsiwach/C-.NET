using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    private static Dictionary<string, string> Users = new();

    public override Task OnConnectedAsync()
    {
        var username = Context.GetHttpContext().Request.Query["username"].ToString();

        if (!string.IsNullOrEmpty(username))
        {
            Users[username] = Context.ConnectionId;
        }

        return base.OnConnectedAsync();
    }

    public async Task SendPrivateMessage(string receiver, string message)
    {
        if (Users.TryGetValue(receiver, out var connectionId))
        {
            await Clients.Client(connectionId)
                .SendAsync("ReceivePrivateMessage", Context.ConnectionId, message);
        }
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        var user = Users.FirstOrDefault(x => x.Value == Context.ConnectionId);
        if (!string.IsNullOrEmpty(user.Key))
        {
            Users.Remove(user.Key);
        }

        return base.OnDisconnectedAsync(exception);
    }
}