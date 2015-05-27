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


        public void DrawCard()
        {
            var rnd = new Random();

            int SuitIndex1 = rnd.Next(Suits.Length);
            int SuitIndex2 = rnd.Next(Suits.Length);


            string Card = CardDeck.Keys.ElementAt(CardDeck.Count - 1);


        }
    }
}


//return ((CardDeck[]) + " of " + (Suits[SuitIndex1]) + " & " + (Cards[CardsIndex2]) + " of " + (Suits[SuitIndex2]));
       // }

        //public int DrawValue()
        //{
            

        //}
        
   // }

    
    
   
//}
