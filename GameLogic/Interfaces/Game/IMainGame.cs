using GameLogic.Models;
using GameLogic.Models.Cards;

namespace GameLogic.Interfaces.Game
{
    public interface IMainGame<MainGame>
    {
        public GameState GameState { get; set; }
        public Deck Deck { get; }
    }
}
