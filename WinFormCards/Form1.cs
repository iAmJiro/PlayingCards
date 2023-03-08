using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1___PlayingCards;

namespace WinFormCards
{
    public partial class Form1 : Form
    {
        private Deck deck;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            List<Image> list = new List<Image>();
            List<Image> ttwocards = new List<Image>();

            for (int i = 0; i <= 7; i++) 
            {
                ttwocards.Add(imageList1.Images[i]);
            }
            for (int i = 13; i <= 20; i++) 
            {
                ttwocards.Add(imageList1.Images[i]);
            }
            for (int i = 26; i <= 33; i++) 
            {
                ttwocards.Add(imageList1.Images[i]);
            }
            for (int i = 39; i <= 46; i++) 
            {
                ttwocards.Add(imageList1.Images[i]);
            }// 32 cards, 8 from each suit

            for (int i = 0; i <= 51; i++) 
            {
                list.Add(imageList1.Images[i]);
            }// adds all cards to the list ye
            deck.AssignImages(list, imageList1.Images[52]);
            deck.Shuffle();
            if (deck.isEmpty()) 
            {
                PictureBoxDeck.Image = imageList1.Images[52];
            }
        }

        private void PictureBoxDeck_Click(object sender, EventArgs e)
        {
            //while (!deck.isEmpty()) { PictureBoxCard.Image = deck.DealTopCard().GetImage();}
            if (!deck.isEmpty())
            {
                PictureBoxCard.Image = deck.DealTopCard().GetImage();
            }
            else
            {
                PictureBoxCard.Image = imageList1.Images[52];
            }
        }
    }
}
