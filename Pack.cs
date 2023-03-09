using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903MA012223.Card;
using static CMP1903MA012223.Pack;
using static CMP1903MA012223.Testing;

namespace CMP1903MA012223
{
    class Pack //: Card
    {
        //readonly int total_cards = 52; //total number of playing cards
        //private static Card[] deck; // all of the playing cards, private so the cards don't get changed

        public static List<Card> pack = new List<Card>();
        public static List<Card> split_deck1 = new List<Card>();
        public static List<Card> split_deck2 = new List<Card>();
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

        /*public static Card[] Getpack //retrieving cards
        {
            get
            {
                return deck; // get deck
            }
        }*/
        public static void Decksetup() // creation of cards
        {
            /*int i = 0;
            foreach (CardSuits s in Enum.GetValues(typeof(CardSuits)))
            {
                foreach (Cardvalues v in Enum.GetValues(typeof(Cardvalues)))
                {
                    enumdeck = deck[i];
                    enumdeck = new Card { _CardSuits = s, _Cardvalues = v };
                    i++; // index i should increment up to 52 cards
                }
            }*/
            //chagen enum to list first

            System.Console.WriteLine("What kind of shuffle do you want to use: \n1. Fisher-Yates shuffle\n2. Riffle shuffle\n3. No shuffle\n");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                ShuffleCardPack(1);
            }
            else if (answer == 2)
            {
                ShuffleCardPack(2);
            }
            else if (answer == 3)
            {
                ShuffleCardPack(3);
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
                split_deck1.AddRange(pack.GetRange(1, 26)); //FIX THIS!!
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
