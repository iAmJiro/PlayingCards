using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1___PlayingCards
{
    public class PlayingCard : IComparable<PlayingCard>
    {
        private int points;
        private bool isFaceUp;
        private int id;
        private string name;
        private string abbrev;

        private CardRank rank;
        private CardSuit suit;
        private Image frontImage;
        private Image backImage;

        public int Points 
        {
            get { return points; } 
            set { points = value; } 
        }
        public bool IsFaceUp 
        {
            get { return isFaceUp;}
            set { isFaceUp = value;}
        }
        public int Id 
        {
            get { return id;}
            set { id = value;}
        }
        public string Name 
        {
            get { return name;}
            set { name = value;}
        }
        public string Abbrev 
        {
            get { return abbrev;}
            set { abbrev = value;}
        }
        public CardRank Rank
        {
            get { return rank;}
            set { rank = value;}
        }
        public CardSuit Suit 
        {
            get { return suit;}
            set { suit = value;}
        }
        public Image FrontImage 
        {
            get { return frontImage;}
            set { frontImage = value;}
        }
        public Image BackImage 
        {
            get { return backImage;}
            set { backImage = value;}
        }

        public PlayingCard(CardRank rank, CardSuit suit)
        {
            Id = ((int) Suit * 13) + (int) Rank;
            Name = String.Format("{0} of {1}", Rank, Suit);
            Abbrev = GetDefaultAbbrev();
            Rank = rank;
            Suit = suit;
            FrontImage = null;
            BackImage = null;
            Points = 0;
        }
        public string GetDefaultAbbrev() 
        {
            if (Rank >= CardRank.Two && Rank <= CardRank.Nine) 
            {
                return String.Format("{0}{1}", (int)Rank.ToString()[1] + 1, Suit.ToString()[0]);
            }
            else 
            {
                return String.Format("{0}{1}", Rank.ToString()[0], Suit.ToString()[0]);
            }
        }
        public void Flip() 
        {
            IsFaceUp = !IsFaceUp;
        }
        public Image GetImage()
        {
            if (IsFaceUp)
            {
                return FrontImage;
            }
            else 
            {
                return BackImage;
            }
        }
        public override string ToString()
        {
            return Name;
        }
        public int CompareTo(PlayingCard other)
        {
            return Suit.CompareTo(other.Rank);
            /*int cmp = Suit.CompareTo(other.Suit);
            if (cmp == 0) 
            {
                cmp = Rank.CompareTo(other.Rank);
            }
            return cmp;*/
        }
    }
}
