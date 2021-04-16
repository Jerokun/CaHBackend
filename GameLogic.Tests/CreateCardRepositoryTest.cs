using System.Linq;
using Xunit;
using System;
using System.Collections.Generic;
using GameLogic.Models;
using GameLogic.DataConverter;
using GameLogic.Models.Cards;

namespace GameLogic.Tests
{
    public class CreateCardRepositoryTest
    {
        [Fact]
        public void CreateCardRepositoryFromJsonContainsNoEmpty()
        {
            //Arrange
            var packname = "Hilarious!";

            //Act
            Dictionary<string, Pack> cardCollection = PackRepository.LoadCardCollection();
            IEnumerable<WhiteCard> whiteCardsInPack = cardCollection[packname].WhiteCards;
            bool doesThisCardExistInPackEmpty = whiteCardsInPack.Any(card => card.Text == "");

            //Assert
            Assert.False(doesThisCardExistInPackEmpty);
        }


        [Fact]
        public void CreateCardRepositoryFromJson()
        {
            //Arrange
            string packname = "Hilarious!";

            //Act
            Dictionary<string, Pack> cardCollection = PackRepository.LoadCardCollection();
            IEnumerable<WhiteCard> whiteCardsInPack = cardCollection[packname].WhiteCards;
            bool doesThisCardExistInPackOral = whiteCardsInPack.Any(card => card.Text == "Oral sex that tastes like urine.");

            //Assert
            Assert.True(doesThisCardExistInPackOral);

        }
    }
}
