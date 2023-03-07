using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack : Card
    {
        int total_cards = 52; //total number of playing cards
        private Card[] deck; // all of the playing cards, private so the cards don't get changed

        List<Card> pack;
        public Pack()
        {
            //Initialise the card pack here

            deck = new Card[total_cards];
        }

        public Card[] getpack
        {

            get
            {
                return deck; // get deck
            }
             
        }
        
        public void decksetup() // creation of cards
        {

            for (int i = 0; i < suitvalues.Length; i++)
            {
                for (int j = 0; i < cardvalues.Length; i++);
                {
                    deck[i][j] = new Card {Suit = i, Value = j};
                }
            }

        }
        
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            // 1. Fisher-Yates shuffle
            // 2. Riffle shuffle
            // 3. No shuffle


            // PUT THIS IN A LOOP
            System.Console.WriteLine("Choose what type of shuffle you want to use: \n1. Fisher-Yates shuffle\n2. Riffle Shuffle\n3. No Shuffle\n");

            try // not sure if the user input will automaticaly be int or string
            {
                int typeOfShuffle = Console.ReadLine();
            }
            catch
            {
                int.Parse(typeOfShuffle);
            }
            
            if (typeOfShuffle == "1")
            {
                typeOfShuffle = "Fisher-Yates Shuffle";
            }
            if (typeOfShuffle == "2")
            {
                typeOfShuffle = "Riffle Shuffle";
            }
            if (typeOfShuffle == "3")
            {
                typeOfShuffle = "No Shuffle";
            }

            System.Console.WriteLine("You have chosen " + usershuffle);

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
