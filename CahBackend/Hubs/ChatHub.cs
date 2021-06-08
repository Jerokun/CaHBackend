using CahBackend.Lobby;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CahBackend.Hubs
{
    public class ChatHub : Hub<IHubClient>
    {
        public async Task SendMessage(ChatMessage chatMessage)
        {
            await Clients.All.SendAsync(chatMessage);
        }
    }
}