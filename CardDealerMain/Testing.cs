using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing() { 
            //Create a new pack of cards
            Pack pack = new Pack();
            //Shuffle the pack
            bool shuffle = Pack.shuffleCardPack(1);
            System.Console.WriteLine(shuffle);
            //Deal the pack
            Card deal = Pack.deal();
            System.Console.WriteLine("Value = " + deal.Value);
            System.Console.WriteLine("Suit = " + deal.Suit);
            //Shuffle the pack
            shuffle = Pack.shuffleCardPack(2);
            Console.WriteLine(shuffle);
            //Deal the pack
            List<Card> deals = Pack.dealCard(3);
            int i = 1;
            foreach (Card card in deals)
            {
                System.Console.WriteLine("Card = " + i++);
                System.Console.WriteLine("Value = " + card.Value);
                System.Console.WriteLine("Suit = " + card.Suit);
            }
            //Shuffle the pack
            shuffle = Pack.shuffleCardPack(3);
            System.Console.WriteLine(shuffle);
            //Deal the pack
            deals = Pack.dealCard(5);
            i = 1;
            foreach (Card card in deals)
            {
                System.Console.WriteLine("Card = " + i++);
                System.Console.WriteLine("Value = " + card.Value);
                System.Console.WriteLine("Suit = " + card.Suit);
            }
        }
    }
}
