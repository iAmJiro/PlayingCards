using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1___PlayingCards
{
    public class Deck
    {
        public static Random rnd = new Random();
        protected List<PlayingCard> cards = new List<PlayingCard>();
        public Deck() 
        {
            for (CardSuit suit = CardSuit.Clubs; suit <= CardSuit.Spades; suit++) 
            {
                for (CardRank rank = CardRank.Ace; rank <= CardRank.King; rank++) 
                {
                    cards.Add(new PlayingCard(rank, suit));
                }
            }
        }//constructor
        /*public void TestDeck() 
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    cards.Add(new PlayingRank(suit, rank);
                }
            }

        --------+---------

            for (CardSuit suit = CardSuit.Clubs; suit <= CardSuit.Spades; suit++)
            {
                for (CardRank rank = CardRank.Ace; rank <= CardRank.King; rank++)
                {
                    cards.Add(new PlayingCard(rank, suit));
                }
            }
        }*/
        public Deck(params CardRank[] ranks) 
        {
            for (CardSuit suit = CardSuit.Clubs; suit <= CardSuit.Spades; suit++)
            {
                for (CardRank rank = CardRank.Ace; rank <= CardRank.King; rank++)
                {
                    if (ranks.Contains(rank))
                    {
                        cards.Add(new PlayingCard(rank, suit));
                    }
                }
            }
        }//overload constructor
        public bool isEmpty() 
        {
            return cards.Count() == 0;
        }
        public PlayingCard DealTopCard() 
        {
            if (isEmpty())
            {
                return null;
            }
            else 
            {
                PlayingCard storedCard = cards[0];
                cards.RemoveAt(0);
                return storedCard;
            }
        }
        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 1; i--)
            {
                int pos = rnd.Next(i);
                PlayingCard tmp = cards[i];
                cards[i] = cards[pos];
                cards[pos] = tmp;
            }
        }
        public void AssignImages(List<Image> faces, Image back)
        {
            if (faces.Count == cards.Count)
            {
                for (int i = 0; i < faces.Count; i++)
                {
                    cards[i].FrontImage = faces[i];
                    cards[i].BackImage = back;
                }
            }
            else
            {
                throw new Exception("Cardlist size doesn't match deck size");
            }
        }
    }
}
