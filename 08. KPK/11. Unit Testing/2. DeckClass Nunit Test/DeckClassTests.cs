namespace DeckClassNunitTest
{
    using System;
    using NUnit.Framework;

    using Santase.Logic;
    using Santase.Logic.Cards;
    [TestFixture]
    public class DeckClassTests
    {
        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void ExpectGetNextCardToThrowWhenDrawingMoreThanTheDeckSize()
        {
            var deck = new Deck();
            for (int i = 0; i < 25; i++)
            {
                var card = deck.GetNextCard();
            }
        }
        [Test]
        public void ExpectTrumpCardToBeCorrectAfterAChange()
        {
            var deck = new Deck();
            var trumpCard = deck.GetNextCard();
            deck.ChangeTrumpCard(trumpCard);
            Assert.AreSame(deck.GetTrumpCard, trumpCard);
        }

        [TestCase(5)]
        [TestCase(15)]
        [TestCase(20)]
        public void ExspectCardsLeftToGiveTheCorrectAmount(int amount)
        {
            var expectedCards = 24 - amount;
            var deck = new Deck();
            for (int i = 0; i < amount; i++)
            {
                var card = deck.GetNextCard();
            }
            Assert.AreEqual(expectedCards, deck.CardsLeft);
        }
    }
}
