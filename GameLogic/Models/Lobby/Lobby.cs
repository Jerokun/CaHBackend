using GameLogic.Models.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.Models.Lobby
{
    public class Lobby
    {
        public Guid Id { get; set; }
        public List<Player> Players { get; set; }
        public IEnumerable<string> PackNames { get; set; }
        public bool IsPrivate { get; set; }

        public Lobby()
        {
            Players.Add(new Player("MrHost")
            {
                IsHost = true
            });
        }
    }
}
