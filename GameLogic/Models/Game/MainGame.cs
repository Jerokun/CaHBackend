using GameLogic.Interfaces.Game;
using GameLogic.Models.Cards;
using GameLogic.Models.Lobby;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Models.Game
{
    class MainGame : IMainGame<MainGame>
    {
        public GameState GameState { get; set; }
        public Deck Deck { get; set; }
        public Lobby.Lobby Lobby { get; set; }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
