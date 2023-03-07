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


        public int[] cardvalues = {1,2,3,4,5,6,7,8,9,10,12,13};
        public int[] suitvalues = {1,2,3,4};


        public int Value
        {get; set;}
        
        public int Suit
        {get; set;}
    }
}
