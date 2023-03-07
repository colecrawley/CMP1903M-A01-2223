using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack : Card
    {
        const int total_cards = 52; //total number of playing cards
        private Card[] deck; // all of the playing cards, private so the cards don't get changed

        public static List<Card> pack = new List<Card>();
        public static List<Card> split_deck1 = new List<Card>();
        public static List<Card> split_deck2 = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            deck = new Card[total_cards]; // stores all the cards
        }

        public Card[] Getpack //retrieving cards
        {
            get
            {
                return deck; // get deck
            }
        }
        public void Decksetup() // creation of cards
        {
            int i = 0;
            foreach (CardSuits s in Enum.GetValues(typeof(CardSuits)))
            {
                foreach (Cardvalues v in Enum.GetValues(typeof(Cardvalues)))
                {
                    deck[i] = new Card { Suit = (int)s, Value = (int)v };
                    i++; // index i should increment up to 52 cards
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
                System.Console.WriteLine("You have chosen the Fisher-Yates Shuffle");
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
                System.Console.WriteLine("You have chosen the Riffle Shuffle");
                // need to divide the pack of cards into two sets
                split_deck1.AddRange(pack.GetRange(0, 26));
                split_deck2.AddRange(pack.GetRange(27,52));

                int i = 0;
                int j = 0;
                while (i < 52)
                {
                    pack[i] = split_deck1[j];
                    i++;
                    pack[i] = split_deck2[j];
                    i++;
                    j++;
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                System.Console.WriteLine("You have chosen not to shuffle the deck of cards");
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

        }
        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
