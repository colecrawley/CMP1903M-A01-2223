using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static CMP1903MA012223.Card;
//using static CMP1903MA012223.Pack;
//using static CMP1903MA012223.Testing;

namespace CMP1903MA012223
{
    class Pack //: Card
    {
        //readonly int total_cards = 52; //total number of playing cards
        //private static Card[] deck; // all of the playing cards, private so the cards don't get changed

        public static List<Card> pack = new List<Card>();
        public static List<Card> split_deck = new List<Card>();
        public static List<Card> drawncards = new List<Card>();
        public static List<Card> dealt_cards = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            //deck = new Card[total_cards]; // stores all the cards

            int i = 1;
            int j = 1;

            while (j != 5)
            {
                pack.Add(new Card(i, j));
                i++;
                if (i == 13)
                {
                    i = 1;
                    j++;
                }
            }
        }
        
        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            // 1. Fisher-Yates shuffle
            // 2. Riffle shuffle
            // 3. No shuffle

            if (typeOfShuffle == 1)
            {
                System.Console.WriteLine("\nYou have chosen the Fisher-Yates Shuffle\n");
                Random rand = new Random();
                for (int i = 0; i < pack.Count; i++)
                {
                    int j = rand.Next(i, pack.Count);
                    (pack[j], pack[i]) = (pack[i], pack[j]);
                }
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                System.Console.WriteLine("\nYou have chosen the Riffle Shuffle\n");
                // need to divide the pack of cards into two sets

                int i = 0;
                while (i < (pack.Count / 2))
                {
                    split_deck.Add(pack[i]);
                    split_deck.Add(pack[i + (pack.Count / 2)]);
                    i++;
                }
                pack = split_deck;
                return true;
            }

            else if (typeOfShuffle == 3)
            {
                System.Console.WriteLine("\nYou have chosen not to shuffle the deck of cards\n");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Card Deal()
        {
            //Deals one card

            //Decksetup(); //Create the deck
            Card Stack = pack[-1];
            pack.RemoveAt(-1);
            dealt_cards.Add(Stack);
            drawncards.AddRange(dealt_cards);
            return Stack;
        }

        public static void Showcards() // display all the cards
        {
            int i = 0;
            foreach (Card card in pack)
            {
                card.Currentcard(); //double check this
                i++;
            }
        }

        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

            
            if (pack.Count < amount)
            {
                throw new ArgumentOutOfRangeException("Impossible to draw " + amount + "cards because there are not enough cards left in the pack");
            }
            else
            {
                for (int i = 1; i <= amount; i++)
                {
                    Card Stack = pack[-1];
                    pack.RemoveAt(-1);
                    dealt_cards.Add(Stack);
                }
                dealt_cards.AddRange(dealt_cards);
                return dealt_cards;
            }
        }
    }
}
