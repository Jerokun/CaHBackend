using GameLogic.Models;
using GameLogic.Models.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.Interfaces
{
    interface IDeckGenerator<DeckGenerator>
    {
        public string[] GetPackNames();
        public Deck GetDeck(string[] packNames);
    }
}
