using CahBackend.Lobby;
using System.Threading.Tasks;

namespace CahBackend.Hubs
{
    public interface IHubClient
    {
        Task SendAsync(ChatMessage messageDto);
    }
}
