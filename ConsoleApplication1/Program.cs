using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Welcome to BlackJack, time to gamble! Hit enter and we will get underway with the deal");
            Console.ReadLine();
            Console.WriteLine(game.DrawInitialPlayerCards());
            Console.WriteLine("Hit enter for the Casino's draw");
            Console.ReadLine();
            Console.WriteLine(game.DrawInitialHouseCards());
            Console.WriteLine("");
            Console.WriteLine("Would you like to be Hit, enter yes or no");
            game.Hit(Console.ReadLine());
            Console.ReadLine();

        }
    }
}
