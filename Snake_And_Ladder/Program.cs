using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            //The moment of player tracked by this varable
            int Position = 0;
            //creating random object for Random class
            Random random = new Random();
            //UC2 Getting a random input
            //Rolling a die to get a number between 1 and 6
            int Number = random.Next(1, 7);
            //UC3 Rules to play
            if (Number == 3)
            {
                //In This case no move stay in same place
                Console.WriteLine("No Play");
            }
            else
            {
                if (Number == 2)
                {
                    Console.WriteLine("It is a Snake");
                    //Its a lader so move backward that means position  will we decrement with respect to Number
                    Position -= Number;

                }
                else
                {
                    Console.WriteLine("It is a Ladder");
                    //Its a lader so move forward that means position  will we incremented with respect to Number
                    Position += Number;
                }
            }
            Console.Read();
        }
    }
}
