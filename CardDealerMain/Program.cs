using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{

        static public void Main(string[] args)
		{   
        Pack pack = new Pack();
            int exit = 1;
            while(exit != 0)
            {
                int choice = 0;
                Console.WriteLine("Enter type of shuffle: ");
                Console.WriteLine("1. Fisher-Yates Shuffle");
                Console.WriteLine("2. Riffle Shuffle");
                Console.WriteLine("3. No Shuffle");
                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                return;
                }
               
                if (Pack.shuffleCardPack(choice))
           
                {
                    Console.WriteLine("Shuffle successful");
                  
                }
                else
                {
                    Console.WriteLine("Shuffle unsuccessful");
                }
                Console.WriteLine("Enter number of cards to deal: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num <= 52)
                {
                    if (num == 1)
                    {
                        Card deal = Pack.deal();
                        System.Console.WriteLine("Value = " + deal.Value);
                        System.Console.WriteLine("Suit = " + deal.Suit);
                    }
                    else
                    {
                        List<Card> deals = Pack.dealCard(num);
                        int i = 1;
                        foreach (Card card in deals)
                        {
                            System.Console.WriteLine("Card = " + i++);
                            System.Console.WriteLine("Value = " + card.Value);
                            System.Console.WriteLine("Suit = " + card.Suit);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Invalid number of cards to deal");
                }
            }
        }
        
}
