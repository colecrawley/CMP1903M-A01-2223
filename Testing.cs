using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MA012223
{
    internal class Testing
    {
        public static void testing() //put everything into one big method
        {
            
            //Creating pack 
            Pack deck = new Pack(); 

            //Default arrangement of the cards
            System.Console.WriteLine("\n\tDefault arrangement\n");
            Pack.Showcards();

            //Different shuffles

            //Fisher-Yates shuffle
            System.Console.WriteLine("\n\tThis is the Fisher-Yates shuffle\n");
            Pack.ShuffleCardPack(1);
            Pack.Showcards();

            //Riffle Shuffle
            System.Console.WriteLine("\n\tThis is the Riffle shuffle\n");
            Pack.ShuffleCardPack(2);
            Pack.Showcards();

            //No Shuffle
            System.Console.WriteLine("\n\tThis is the No shuffle\n");
            Pack.ShuffleCardPack(3);
            Pack.Showcards();

            //Deal one card
            System.Console.WriteLine("\n\tDeal one card\n");
            Pack.Deal().Currentcard();

            //Current state of the deck now
            System.Console.WriteLine("\n\tShow deck\n");
            Pack.Showcards();

            //Dealing multiple cards at once
            System.Console.WriteLine("\n\tDealing a number of cards at a time\n");

            Pack.DealCard(5);
            foreach (Card item in Pack.dealt_cards.Distinct().ToList())
            {
                item.Currentcard();
            }

            //Showing the current deck
            System.Console.WriteLine("\n\tDisplay current state of deck\n");
            Pack.Showcards();

            //Showing drawn cards
            System.Console.WriteLine("\n\tDrawn cards\n");
            foreach (Card item in Pack.drawncards.Distinct().ToList())
            {
                item.Currentcard();
            }

            //Showing dealt cards
            System.Console.WriteLine("\n\tDealt cards\n");
            foreach (Card item in Pack.dealt_cards.Distinct().ToList())
            {
                item.Currentcard();
            }

            
        }
    }

}
