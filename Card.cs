using System.Runtime.CompilerServices;
using System.Globalization;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CMP1903MA012223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        private int val;
        private int suit_;

        
        public void Currentcard()
        {
            //These are the individual values that each card has
            string[] cardvalues = { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "jack", "queen", "king" };
            string[] cardsuits = { "hearts", "spades", "diamonds", "clubs" };

            System.Console.WriteLine(cardvalues[Value - 1] + " of "+ cardsuits[Suit-1]); //formatting of the output
        }


        public int Value
        {
            get
            {
                return val;
            }

            set
            {
                if (value >= 1 || value <= 13) //boundary checking
                {
                    val = value;
                }
                else
                {
                    System.Console.WriteLine("That is out of bounds, value must be between 1 - 13"); // exception handling

                }
            }
        }
        public int Suit
        {
            get
            {
                return suit_;
            }
            set
            {
                if (value >= 1 || value <= 4) // boundary checking
                {
                    suit_ = value;
                    
                }
                else
                {
                    System.Console.WriteLine("That is out of bounds, suit must be between 1 - 4"); //exception handling
                }
            }
        }

        public Card(int i, int j) //card constuctor
        {
            Value = i;
            Suit = j;
        }

    }
}
