﻿using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903MA012223.Pack;
using static CMP1903MA012223.Card;

namespace CMP1903MA012223
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Creating pack 
            Pack Deckpack = new Pack();

            //Default arrangement of the cards
            System.Console.WriteLine("\n\tDefault arrangement\n");
            Pack.Showcards();

            //Ask user what type of shuffle they want
            Pack.Decksetup();

            //Different shuffles
            //Fisher-Yates shuffle
            System.Console.WriteLine("\n\tThis is the Fisher-Yates shuffle\n");
            Pack.ShuffleCardPack(1);
            Pack.Showcards();

            //RIffle Shuffle
            System.Console.WriteLine("\n\tThis is the Riffle shuffle\n");
            Pack.ShuffleCardPack(2);
            Pack.Showcards();

            //No Shuffle
            System.Console.WriteLine("\n\tThis is the No shuffle\n");
            Pack.ShuffleCardPack(3);
            Pack.Showcards();

            System.Console.WriteLine("\n\tDeal one card\n");
            Pack.Deal().Currentcard();

            System.Console.WriteLine("\n\tShow deck\n");
            Pack.Showcards();

            System.Console.WriteLine("\n\tDealing a number of cards at a time\n");
            Pack.DealCard(6);
            for (int i = 0; i < Pack.dealt_cards.Count; i++)
            {
                Deckpack.Currentcard();
            }
            System.Console.WriteLine("\n\tDisplay pack\n");
            Pack.Showcards();

            System.Console.WriteLine("\n\tDrawn cards\n");
            for (int i = 0; i < Pack.drawncards.Count; i++)
            {
                Deckpack.Currentcard();
            }

            System.Console.WriteLine("\n\tDealt cards\n");
            for (int i = 0; i < Pack.dealt_cards.Count; i++)
            {
                Deckpack.Currentcard();
            }
        }
    }
}
