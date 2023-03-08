using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1___PlayingCards;

namespace TestLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            while (!deck.isEmpty()) 
            {
                PlayingCard TopCard = deck.DealTopCard();
                Console.WriteLine(TopCard);
            }
        }
    }
}
