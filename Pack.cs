using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MA012223
{
    class Pack
    {

        public static List<Card> pack = new List<Card>();
        public static List<Card> split_deck = new List<Card>();
        public static List<Card> drawncards = new List<Card>();
        public static List<Card> dealt_cards = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            int i = 1;
            int j = 1;

            while (j != 5) //This creates the cards and stores it in Pack
            {
                pack.Add(new Card(i, j));
                i++;
                if (i == 13) //runs through all the card values, once it reaches the 13th value, it restarts at 1 and moves on to the next suit
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

            if (typeOfShuffle == 1) // fisher-yates shuffle
            {
                System.Console.WriteLine("\nYou have chosen the Fisher-Yates Shuffle\n");
                Random rand = new Random();
                for (int i = 0; i < pack.Count; i++)
                {
                    int j = rand.Next(i, pack.Count); // choosing a random card in the deck to swap positions with
                    (pack[j], pack[i]) = (pack[i], pack[j]); // swapping the positions
                }
                return true;
            }
            else if (typeOfShuffle == 2) // riffle shuffle
            {
                System.Console.WriteLine("\nYou have chosen the Riffle Shuffle\n");
                // need to divide the pack of cards into two sets

                int i = 0;
                while (i < (pack.Count / 2)) //first half of the deck 0-25
                {
                    split_deck.Add(pack[i]);
                    split_deck.Add(pack[i + (pack.Count / 2)]); // second half of the deck 26-51
                    i++;
                }
                pack = split_deck;
                return true;
            }

            else if (typeOfShuffle == 3) // no shuffle, should be the same as riffle shuffle deck
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

            Card Stack = pack[5]; // picks card number 4 in the deck
            pack.RemoveAt(5); // removes card 4 from deck because it has been dealt to the user
            dealt_cards.Add(Stack); 
            drawncards.AddRange(dealt_cards);
            return Stack;
        }

        public static void Showcards() // display all the cards
        {
            int i = 0;
            foreach (Card card in pack)
            {
                card.Currentcard();
            }
        }

        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            dealt_cards.Clear();

            for (int i = 1; i <= amount; i++) // draws the amount of cards specified
            {
                Card Stack = pack[5];
                pack.RemoveAt(5);
                dealt_cards.Add(Stack);
            }
            dealt_cards.AddRange(dealt_cards);
            return dealt_cards;
            
        }
    }
}
