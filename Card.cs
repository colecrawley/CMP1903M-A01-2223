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

        private readonly int val;
        private readonly int suit_;
        public int number;

        public enum Cardvalues
        {
            two = 2, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace
        }
        public enum CardSuits
        {
            hearts, spades, diamonds,clubs
        }
        public void Currentcard()
        {
            int enumvalue = Value;
            var cardvalues = (Cardvalues)Value;
            string stringValue = cardvalues.ToString();

            int enumsuit = Suit;
            var cardsuits = (CardSuits)Suit;
            string stringSuit = cardsuits.ToString();

            System.Console.WriteLine(stringValue + " of " + stringSuit);
        }

        public int Value
        {
            get
            {
                return val;
            }

            set
            {
                if (number < 1 || number > 13)
                {
                    System.Console.WriteLine("That is out of bounds, value must be between 1 - 13");
                }
                else
                {
                    Value = number;
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
                if (number < 1 || number > 4)
                {
                    System.Console.WriteLine("That is out of bounds, suit must be between 1 - 4");
                }
                else
                {
                    Suit = number;
                }
            }
        }
    }
}
