using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GameLogic.Decks;
using GameLogic.Models;
using System.Linq;
using GameLogic.Models.Cards;

namespace GameLogic.Tests
{
    public class DeckGeneratorTests
    {
        [Fact]
        public void GetDeckFromPacknamesContainsNoEmpty()
        {
            //Arrange
            string[] packnames =
            {
                "Hilarious!",
                "Cows Against Hamburgers - Patty Pack #1",
            };
            var dGen = new DeckGenerator();

            //Act
            Deck deck = dGen.GetDeck(packnames);

            //Assert
            Assert.NotNull(deck);
        }

        [Fact]
        public void GetDeckFromPacknamesContainsCardsFromPacknames()
        {
            //Arrange
            string[] packnames =
            {
                "Hilarious!",
                "Cows Against Hamburgers - Patty Pack #1",
            };
            var dGen = new DeckGenerator();

            //Act
            Deck deck = dGen.GetDeck(packnames);

            //Assert
            Assert.Equal(packnames[0], (deck.BlackCards.First()).PackName);
        }

        [Fact]
        public void GetPackNamesContainsName()
        {
            //Arrange
            var dGen = new DeckGenerator();
            string name = "Hilarious!";

            //Act
            IEnumerable<string> packNames = dGen.GetPackNames();

            //Assert
            Assert.Contains(name, packNames);
        }

        [Fact]
        public void GetDeckShuffleDoesNotCreateIdenticalObject()
        {
            //Arrange
            string[] packnames =
            {
                "Hilarious!",
                "Cows Against Hamburgers - Patty Pack #1",
            };
            var dGen = new DeckGenerator();

            //Act
            Deck firstDeck = dGen.GetDeck(packnames);
            Deck secondDeck = dGen.GetDeck(packnames);

            //Assert
            Assert.True(firstDeck != secondDeck);
        }

        [Fact]
        public void GetDeckShuffleChangesFirstCardOfDecks()
        {
            //Arrange
            string[] packnames =
            {
                "Hilarious!",
                "Cows Against Hamburgers - Patty Pack #1",
            };
            var dGen = new DeckGenerator();

            //Act
            Deck firstDeck = dGen.GetDeck(packnames);
            Deck secondDeck = dGen.GetDeck(packnames);

            var card1 = firstDeck.BlackCards.First();
            var card2 = secondDeck.BlackCards.First();

            //Assert
            Assert.False(card1.Text == card2.Text);
        }
    }
}
