using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    class Program
    {
        //SnakeAndLadder Program
        static void Main(string[] args)
        {
            //The moment of player tracked by this varable
            int Position = 0;
            //creating random object for Random class
            Random random = new Random();
            //UC2 Getting a random input
            //Rolling a die to get a number between 1 and 6
            int Number = random.Next(1, 7);
            Console.Read();
        }
    }
}
