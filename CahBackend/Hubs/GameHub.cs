using GameLogic.Models.Game;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CahBackend.Hubs
{
    public class GameHub : Hub
    {
        public Task SendMessage1(string user, GameState gameState)
        {
            return Clients.All.SendAsync("ReceiveOne", user, gameState);
        }
    }
}
