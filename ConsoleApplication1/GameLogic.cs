using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackVS
{

    public class Game
    {

        public string[] Suits { get; set; }
        public Dictionary<string, int> CardDeck { get; set; }

        Player Player = new Player();
        House Casino = new House();

        public Game()
        {

            Player.score = 0;
            Casino.score = 0;

            Suits = new string[] { "hearts", "diamonds", "clubs", "spades" };

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
        }



        public string DrawInitialPlayerCards()
        {
            var rnd = new Random();

            int suitIndex1 = rnd.Next(Suits.Length);
            int suitIndex2 = rnd.Next(Suits.Length);
            string card1 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));
            string card2 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));

            Player.score = (CardDeck[card1] + CardDeck[card2]);

            return ("Your Draw is " + card1 + " of " + Suits[suitIndex1] + " and " + card2 + " of " + Suits[suitIndex2] + " thats a scoore of " + Player.score);

        }

        public string DrawInitialHouseCards()
        {
            var rnd = new Random();

            int suitIndex1 = rnd.Next(Suits.Length);
            int suitIndex2 = rnd.Next(Suits.Length);
            string card1 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));
            string card2 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));

            Casino.score = (CardDeck[card1] + CardDeck[card2]);

            return ("The Casino Draw is " + card1 + " of " + Suits[suitIndex1] + " and " + card2 + " of " + Suits[suitIndex2] + " thats a scoore of " + Casino.score);

        }

        public void Hit(string UserAnswer)
        {
            if (UserAnswer == "yes" || UserAnswer == "Yes" || UserAnswer == "YES")
            {
                dealAdditionalUser();
            }
            else
            {
                
            }

        }

        public void dealAdditionalUser()
        {
            Random rnd = new Random();
            int suitIndex1 = rnd.Next(Suits.Length);
            string card1 = CardDeck.Keys.ElementAt(rnd.Next(CardDeck.Count - 1));
            Console.WriteLine("Your draw is" + Suits[suitIndex1] + " of " + card1);
            Console.WriteLine(Player.score = (Player.score + CardDeck[card1]));
            
            checkPlayerWin(Player.score);
        }

        public void DealAdditionalUser()
        {
            
        }

        
        public void checkPlayerWin(int playerScore)
        {
            if (playerScore == 21)
            {
                Console.WriteLine("BlackJack! YOU WIN");
            }

            else if (playerScore > 21)
            {
                Console.WriteLine("Bust, You loose, Its going to be a long walk home from Vegas");
            }

            else
            {
                
            }

        }

        public void CheckDealerWin()
        {
            
        }

    }
}
