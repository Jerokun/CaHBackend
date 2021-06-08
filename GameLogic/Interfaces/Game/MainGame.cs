namespace GameLogic.Interfaces.Game
{
    using GameLogic.Models;
    using GameLogic.Models.Cards;
    using System.Collections.Generic;

    public class MainGame
    {
        public Deck Deck { get; set; }
        public List<Player> Players { get; set; }
    }
}
