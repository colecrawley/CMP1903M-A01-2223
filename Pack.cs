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
        private static Card[] deck; // all of the playing cards, private so the cards don't get changed

        public static List<Card> pack = new List<Card>();
        public static List<Card> split_deck1 = new List<Card>();
        public static List<Card> split_deck2 = new List<Card>();
        public static List<Card> drawncards = new List<Card>();
        public static List<Card> dealt_cards = new List<Card>();
        private static Card[] userhand;

        public Pack()
        {
            //Initialise the card pack here

            deck = new Card[total_cards]; // stores all the cards
        }

        public static Card[] Getpack //retrieving cards
        {
            get
            {
                return deck; // get deck
            }
        }
        public static void Decksetup() // creation of cards
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
            else
            {
                throw new ArgumentException("The value you have inputted is not one of the options available");
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

            Decksetup(); //Create the deck
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
                card.Currentcard();
                i++;
            }
        }
        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            //ask user how many cards they want to deal

            System.Console.WriteLine("Enter the amount of cards you want to receive: ");
            int user_cards = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("You have chosen " + user_cards + " cards\n");
            user_cards = amount;

            userhand = new Card[amount];
            if (pack.Count < amount)
            {
                throw new ArgumentOutOfRangeException("Impossible to draw " + amount + "cards because there are not enough cards left in the pack");
            }
            else
            {
                for (int i = 1; i <= amount; i++)
                {
                    userhand[i] = Getpack[i];
                }
                dealt_cards.AddRange(userhand);
            }
            drawncards.AddRange(dealt_cards);
            return dealt_cards;
        }
    }
}
