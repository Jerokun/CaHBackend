using GameLogic.Models.Lobby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CahBackend.Hubs
{
    public interface IHubClient
    {
        Task SendAsync(ChatMessage messageDto);
    }
}
