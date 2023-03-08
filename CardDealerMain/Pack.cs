using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card card = new Card();
                    card.Suit = i;
                    card.Value = j;
                    pack.Add(card);
                }
            }

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                //Fisher-Yates Shuffle
                Random rg = new Random();
                for (int i = pack.Count - 1; i > 0; i--)
                {
                    int j = rg.Next(i + 1);
                    Card temp = pack[i];
                    pack[i] = pack[j];
                    pack[j] = temp;
                }
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                //Riffle Shuffle
                Random rg = new Random();
                List<Card> leftHalf = pack.GetRange(0, pack.Count / 2);
                List<Card> rightHalf = pack.GetRange(pack.Count / 2, pack.Count - pack.Count / 2);
                pack.Clear();
                while (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    if (rg.Next(2) == 0)
                    {
                        pack.Add(leftHalf[0]);
                        leftHalf.RemoveAt(0);
                    }
                    else
                    {
                        pack.Add(rightHalf[0]);
                        rightHalf.RemoveAt(0);
                    }
                }
                if (leftHalf.Count > 0)
                {
                    pack.AddRange(leftHalf);
                }
                else if (rightHalf.Count > 0)
                {
                    pack.AddRange(rightHalf);
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                //No Shuffle
                return true;
            }
            else
            {
                //Invalid Shuffle
                return false;
            }

        }
        public static Card deal()
        {
            //Deals one card
            Card card = new Card();
            card.Suit = pack[0].Suit;
            card.Value = pack[0].Value;
            pack.RemoveAt(0);
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                Card card = new Card();
                card.Suit = pack[0].Suit;
                card.Value = pack[0].Value;
                pack.RemoveAt(0);
                cards.Add(card);
            }
            return cards;
        }
    }
}
