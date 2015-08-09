using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceString = "";
            string suitString = "";
            switch (this.Face)
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
            switch (this.Suit)
            {
                case CardSuit.Clubs: suitString += "Clubs"; break;
                case CardSuit.Diamonds: suitString += "Diamonds"; break;
                case CardSuit.Hearts: suitString += "Hearts"; break;
                case CardSuit.Spades: suitString += "Spades"; break;
            }
            return string.Format("{0} of {1}", faceString, suitString);
        }
    }
}