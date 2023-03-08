using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___PlayingCards
{
    public class Hand
    {
        protected List<PlayingCard> cards = new List<PlayingCard>();

        public bool isEmpty() 
        {
            return cards.Count() == 0;
        }
        public PlayingCard DealTopCard() 
        {
            if (isEmpty()) return null;
            
            PlayingCard storedCard = cards[0];
            cards.RemoveAt(0);
            return storedCard;
        }
        public void Sort() 
        {
            cards.Sort();
        }
    }
}
