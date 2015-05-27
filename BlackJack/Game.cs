using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public string[] Cards { get; set; }
        public string[] Suits { get; set; }


        public Game()
        {
            Cards = new string[] {"two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king", "ace" };
            Suits = new string[] {"hearts", "diamonds", "clubs", "spades"};
        }


        public string DrawCard()
        {
            var rnd = new Random();
            int CardsIndex1 = rnd.Next(Cards.Length);
            int SuitIndex1 = rnd.Next(Suits.Length);
            int CardsIndex2 = rnd.Next(Cards.Length);
            int SuitIndex2 = rnd.Next(Suits.Length);
            return ((Cards[CardsIndex1]) + " " + (Suits[SuitIndex1]) + " & " + (Cards[CardsIndex2]) + " " + (Suits[SuitIndex2]));
        }
        
    }

    
    
   
}
