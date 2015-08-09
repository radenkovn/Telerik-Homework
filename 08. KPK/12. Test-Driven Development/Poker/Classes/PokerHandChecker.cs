using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var handMaxLenght = 5;
            var cards = hand.Cards;
            if (cards.Count != handMaxLenght)
            {
                return false;
            }

            for (int i = 0; i < cards.Count; i++)
            {
                var checkerCard = cards[i];
                for (int j = 0; j < cards.Count; j++)
                {
                    if (i != j)
                    {
                        var currentCard = cards[j];
                        if (checkerCard.Face == currentCard.Face && checkerCard.Suit == currentCard.Suit)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }
            var cards = hand.Cards;
            if (cards.Where(x => x.Face == cards[0].Face).ToList().Count == 4)
            {
                return true;
            }
            if (cards.Where(x => x.Face == cards[1].Face).ToList().Count == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }
            var cards = hand.Cards;
            var firstCardSuit = cards[0].Suit;
            if (cards.All(x => x.Suit == firstCardSuit))
            {
                return true;
            }
            return false;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}