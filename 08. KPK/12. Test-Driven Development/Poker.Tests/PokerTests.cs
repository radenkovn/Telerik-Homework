namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Poker;
    [TestClass]
    public class PokerTests
    {
        private string ConvertCardToString(ICard card)
        {
            var currentFace = card.Face;
            var currentSuit = card.Suit;
            string faceString = "";
            string suitString = "";
            switch (currentFace)
            {
                case CardFace.Ace: faceString += "Ace"; break;
                case CardFace.Eight: faceString += "Eight"; break;
                case CardFace.Five: faceString += "Five"; break;
                case CardFace.Four: faceString += "Four"; break;
                case CardFace.Jack: faceString += "Jack"; break;
                case CardFace.King: faceString += "King"; break;
                case CardFace.Nine: faceString += "Nine"; break;
                case CardFace.Queen: faceString += "Queen"; break;
                case CardFace.Seven: faceString += "Seven"; break;
                case CardFace.Six: faceString += "Six"; break;
                case CardFace.Ten: faceString += "Ten"; break;
                case CardFace.Three: faceString += "Three"; break;
                case CardFace.Two: faceString += "Two"; break;
            }
            switch (currentSuit)
            {
                case CardSuit.Clubs: suitString += "Clubs"; break;
                case CardSuit.Diamonds: suitString += "Diamonds"; break;
                case CardSuit.Hearts: suitString += "Hearts"; break;
                case CardSuit.Spades: suitString += "Spades"; break;
            }
            return string.Format("{0} of {1}", faceString, suitString);
        }

        [TestMethod]
        public void TestCardToStringReturnsCorrectResults()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var currentFace = (CardFace)i;
                    var currentSuit = (CardSuit)j;
                    var currentCard = new Card(currentFace, currentSuit);

                    var expectedResult = ConvertCardToString(currentCard);
                    Assert.AreEqual(expectedResult, currentCard.ToString());
                }
            }
        }
        [TestMethod]
        public void TestHandToString()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var cards = new List<ICard>();
                    for (int k = 0; k < 5; k++)
                    {
                        var currentFace = (CardFace)((i + k) % 14 + 2);
                        var currentSuit = (CardSuit)((j + k) % 4 + 1);
                        var currentCard = new Card(currentFace, currentSuit);
                        cards.Add(currentCard);
                    }

                    var expectedHandString = "";
                    for (int l = 0; l < cards.Count - 1; l++)
                    {
                        expectedHandString += ConvertCardToString(cards[l]) + ", ";
                    }
                    expectedHandString += ConvertCardToString(cards[cards.Count - 1]);

                    var hand = new Hand(cards);
                    Assert.AreEqual(expectedHandString, hand.ToString());
                }
            }
        }

        [TestMethod]
        public void TestIsValidHandMethodReturnsTrueWhenTheHandIsValid()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var cards = new List<ICard>();
                    for (int k = 0; k < 5; k++)
                    {
                        var currentFace = (CardFace)((i + k) % 14 + 2);
                        var currentSuit = (CardSuit)((j + k) % 4 + 1);
                        var currentCard = new Card(currentFace, currentSuit);
                        cards.Add(currentCard);
                    }
                    var checker = new PokerHandsChecker();
                    var hand = new Hand(cards);
                    Assert.AreEqual(true, checker.IsValidHand(hand), "The IsValid method should return true when the hand is valid");
                }
            }
        }
        [TestMethod]
        public void TestIsValidHandMethodReturnsFalseWhenTheHandConsistsOfEqualCards()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var cards = new List<ICard>();
                    for (int k = 0; k < 5; k++)
                    {
                        var currentFace = (CardFace)(i);
                        var currentSuit = (CardSuit)(j);
                        var currentCard = new Card(currentFace, currentSuit);
                        cards.Add(currentCard);
                    }
                    var checker = new PokerHandsChecker();
                    var hand = new Hand(cards);
                    Assert.AreEqual(false, checker.IsValidHand(hand), "The IsValid method should return false when the hand consists of equal cards");
                }
            }
        }
        [TestMethod]
        public void TestIsValidHandMethodReturnsFalseWhenTheHandConsistsOfLessThanFiveCards()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var cards = new List<ICard>();
                    for (int k = 0; k < 2; k++)
                    {
                        var currentFace = (CardFace)((i + k) % 14 + 2);
                        var currentSuit = (CardSuit)((j + k) % 4 + 1);
                        var currentCard = new Card(currentFace, currentSuit);
                        cards.Add(currentCard);
                    }
                    var checker = new PokerHandsChecker();
                    var hand = new Hand(cards);
                    Assert.AreEqual(false, checker.IsValidHand(hand), "The IsValid method should return false when the hand has less than 5 cards");
                }
            }
        }
        [TestMethod]
        public void TestIsValidHandMethodReturnsFalseWhenTheHandConsistsOfMoreThanFiveCards()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var cards = new List<ICard>();
                    for (int k = 0; k < 8; k++)
                    {
                        var currentFace = (CardFace)((i + k) % 14 + 2);
                        var currentSuit = (CardSuit)((j + k) % 4 + 1);
                        var currentCard = new Card(currentFace, currentSuit);
                        cards.Add(currentCard);
                    }
                    var checker = new PokerHandsChecker();
                    var hand = new Hand(cards);
                    Assert.AreEqual(false, checker.IsValidHand(hand), "The IsValid method should return false when the hand has more than 5 cards");
                }
            }
        }

        [TestMethod]
        public void TestIsFlushMethodReturnsTrueWhenGivenAValidFlushHand()
        {
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var threeSpades= new Card(CardFace.Three, CardSuit.Spades);
            var queenSpades = new Card(CardFace.Queen, CardSuit.Spades);
            var fourSpades = new Card(CardFace.Four, CardSuit.Spades);
            var sevenSpades = new Card(CardFace.Seven, CardSuit.Spades);

            var handList=new List<ICard>();
            handList.Add(twoSpades);
            handList.Add(threeSpades);
            handList.Add(queenSpades);
            handList.Add(fourSpades);
            handList.Add(sevenSpades);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFlush(hand),"The method IsFlush should return true when given a valid flush hand");
        }

        [TestMethod]
        public void TestIsFlushMethodReturnsTrueWhenGivenAnInvalidFlushHand()
        {
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var threeSpades = new Card(CardFace.Three, CardSuit.Spades);
            var queenSpades = new Card(CardFace.Queen, CardSuit.Spades);
            var fourSpades = new Card(CardFace.Four, CardSuit.Spades);

            var sevenClubs = new Card(CardFace.Seven, CardSuit.Clubs);

            var handList = new List<ICard>();
            handList.Add(twoSpades);
            handList.Add(threeSpades);
            handList.Add(queenSpades);
            handList.Add(fourSpades);
            handList.Add(sevenClubs);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand), "The method IsFlush should return true when given an invalid flush hand");
        }

        [TestMethod]
        public void TestIsFlushMethodReturnsTrueWhenGivenAnInvalidhSameCardHand()
        {
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var threeSpades = new Card(CardFace.Three, CardSuit.Spades);
            var queenSpades = new Card(CardFace.Queen, CardSuit.Spades);
            var fourSpadesOne = new Card(CardFace.Four, CardSuit.Spades);
            var fourSpadesTwo = new Card(CardFace.Four, CardSuit.Clubs);

            var handList = new List<ICard>();
            handList.Add(twoSpades);
            handList.Add(threeSpades);
            handList.Add(queenSpades);
            handList.Add(fourSpadesOne);
            handList.Add(fourSpadesTwo);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand), "The method IsFlush should return true when given an invalid same card hand");
        }

        [TestMethod]
        public void TestIsFlushMethodReturnsTrueWhenGivenAnInvalidShortHand()
        {
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);

            var handList = new List<ICard>();
            handList.Add(twoSpades);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand), "The method IsFlush should return false when given an ivalid short hand");
        }
        [TestMethod]
        public void TestIsFlushMethodReturnsTrueWhenGivenAnInvalidLongHand()
        {
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var threeSpades = new Card(CardFace.Three, CardSuit.Spades);
            var queenSpades = new Card(CardFace.Queen, CardSuit.Spades);
            var fourSpades = new Card(CardFace.Four, CardSuit.Spades);
            var sevenSpades = new Card(CardFace.Seven, CardSuit.Spades);
            var tenSpades= new Card(CardFace.Ten, CardSuit.Spades);

            var handList = new List<ICard>();
            handList.Add(twoSpades);
            handList.Add(threeSpades);
            handList.Add(queenSpades);
            handList.Add(fourSpades);
            handList.Add(sevenSpades);
            handList.Add(tenSpades);


            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand), "The method IsFlush should return false when given an ivalid long hand");
        }

        [TestMethod]
        public void TestIfFourOfAKindReturnsTrueWhenGivenAValidFourOfAKindHand()
        {
            var twoHearts = new Card(CardFace.Two, CardSuit.Hearts);
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var twoDiamonds = new Card(CardFace.Two, CardSuit.Diamonds);
            var twoClubs = new Card(CardFace.Two, CardSuit.Clubs);

            var fiveDiamons = new Card(CardFace.Five, CardSuit.Diamonds);

            var handList = new List<ICard>();
            handList.Add(twoHearts);
            handList.Add(twoSpades);
            handList.Add(twoDiamonds);
            handList.Add(twoClubs);
            handList.Add(fiveDiamons);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand), "The method IsFourOfAKind should return true when given a valid hand");
        }

        [TestMethod]
        public void TestIfFourOfAKindReturnsTrueWhenGivenAnInValidFourOfAKindHand()
        {
            var twoHearts = new Card(CardFace.Two, CardSuit.Hearts);
            var fourSpades = new Card(CardFace.Four, CardSuit.Spades);
            var sevenHearts = new Card(CardFace.Seven, CardSuit.Hearts);
            var eightClubs = new Card(CardFace.Eight, CardSuit.Clubs);
            var fiveDiamons = new Card(CardFace.Five, CardSuit.Diamonds);

            var handList = new List<ICard>();
            handList.Add(twoHearts);
            handList.Add(fourSpades);
            handList.Add(sevenHearts);
            handList.Add(eightClubs);
            handList.Add(fiveDiamons);

            var hand = new Hand(handList);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFourOfAKind(hand), "The method IsFourOfAKind should return true when given a non-four of a kind hand");
        }

        [TestMethod]
        public void TestIfFourOfAKindReturnsTrueWhenGivenAnInValidHand()
        {
            var twoHearts = new Card(CardFace.Two, CardSuit.Hearts);
            var twoSpades = new Card(CardFace.Two, CardSuit.Spades);
            var twoDiamonds = new Card(CardFace.Two, CardSuit.Diamonds);
            var twoClubs = new Card(CardFace.Two, CardSuit.Clubs);


            var handList = new List<ICard>();
            handList.Add(twoHearts);
            handList.Add(twoSpades);
            handList.Add(twoDiamonds);
            handList.Add(twoClubs);

            var shortHand = new Hand(handList);
            var duplicatedHand = new Hand(handList);
            duplicatedHand.Cards.Add(twoClubs);
            var longHand = new Hand(handList);
            longHand.Cards.Add(new Card(CardFace.Five, CardSuit.Diamonds));
            longHand.Cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFourOfAKind(shortHand), "The method IsFourOfAKind should return false when given a short hand");
            Assert.AreEqual(false, checker.IsFourOfAKind(duplicatedHand), "The method IsFourOfAKind should return false when given a duplicated hand");
            Assert.AreEqual(false, checker.IsFourOfAKind(longHand), "The method IsFourOfAKind should return false when given a long hand");
        }
    }
}
