using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public string[] Suits { get; set; }
        public Dictionary<string, int> CardDeck { get; set; }


        public Game()
        {
            CardDeck = new Dictionary<string, int>
            {
                {"Two", 2},
                {"Three", 3},
                {"Four", 4},
                {"Five", 5},
                {"Six", 6},
                {"Seven", 7},
                {"Eight", 8},
                {"Nine", 9},
                {"Ten", 10},
                {"Jack", 10},
                {"Queen", 10},
                {"King", 10},
                {"Ace", 10}
            };

            Suits = new string[] {"hearts", "diamonds", "clubs", "spades"};
        }


        public string DrawCard()
        {
            var rnd = new Random();

            int suitIndex1 = rnd.Next(Suits.Length);
            int suitIndex2 = rnd.Next(Suits.Length);
            string card1 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));
            string card2 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));

            return ("The Draw is " + card1 + " of " + Suits[suitIndex1] + " and " + card2 + " of " + Suits[suitIndex2]);

        }


    }
}


