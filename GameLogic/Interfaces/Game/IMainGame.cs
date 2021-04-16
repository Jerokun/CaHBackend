using GameLogic.Models.Cards;
using GameLogic.Models.Game;
using GameLogic.Models.Lobby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Interfaces.Game
{
    interface IMainGame<MainGame>
    {
        public Lobby Lobby { get; set; }
        public GameState GameState { get; set; }
        public Deck Deck { get; }
    }
}
