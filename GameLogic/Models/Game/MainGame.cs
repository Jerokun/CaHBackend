using GameLogic.Interfaces.Game;
using GameLogic.Models.Cards;
using System;

namespace GameLogic.Models
{
    class MainGame : IMainGame<MainGame>
    {
        public GameState GameState { get; set; }
        public Deck Deck { get; set; }

        public void StartGame()
        {
            throw new NotImplementedException();
        }

        public void StopGame()
        {
            throw new NotImplementedException();
        }
    }
}
