using System.Globalization;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        public int val;
        public int suit;
        public int number;

        public enum Cardvalues
        {
            two = 2, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace
        }

        public enum CardSuits
        {
            hearts, spades, diamonds,clubs
        }

        public int Value
        {
            get
            {
                return Value;
            }

            set
            {
                if (number < 1 || number > 13)
                {
                    throw new ArgumentOutOfRangeException("That is out of bounds, value must be between 1 - 13");
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
                return Suit;
            }
            set
            {
                if (number < 1 || number > 4)
                {
                    throw new ArgumentOutOfRangeException("That is out of bounds, suit must be between 1 - 4");
                }
                else
                {
                    Suit = number;
                }
            }
        }

    } 
}
