using GameLogic.DataConverter;
using GameLogic.Models;
using GameLogic.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLogic.Decks
{
    public class DeckGenerator
    {
        public readonly Dictionary<string, Pack> cardCollection = PackRepository.LoadCardCollection();

        public Deck GetDeck(IEnumerable<string> packNames)
        {
            Deck deck = new Deck();
            deck.BlackCards = new List<BlackCard>();
            deck.WhiteCards = new List<WhiteCard>();

            foreach (string p in packNames)
            {
                Pack _pack = GetPack(p);
                IEnumerable<BlackCard> b = deck.BlackCards.Union(_pack.BlackCards);
                IEnumerable<WhiteCard> w = deck.WhiteCards.Union(_pack.WhiteCards);

                deck.BlackCards = b;
                deck.WhiteCards = w;
            }

            deck.BlackCards = deck.BlackCards.OrderBy(i => Guid.NewGuid());
            deck.WhiteCards = deck.WhiteCards.OrderBy(i => Guid.NewGuid());
            return deck;
        }

        public Pack GetPack(string packName)
        {
            return cardCollection[packName];
        }

        public IEnumerable<string> GetPackNames()
        {
            return cardCollection.Keys;
        }
    }
}