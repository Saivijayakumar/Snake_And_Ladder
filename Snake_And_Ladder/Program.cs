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
            int DieCount = 0;
            //creating random object for Random class
            Random random = new Random();
            //UC4 winning score is 100
            while (Position != 100)
            {
                //UC2 Getting a random input
                //Rolling a die to get a number between 1 and 6
                int Number = random.Next(1, 7);
                DieCount++;
                Console.WriteLine("Now The Player is in " + Position + "Position");
                //UC3 Rules to play
                if (Number == 3)
                {
                    //In This case no move stay in same place
                    //Console.WriteLine("No Play"); //This for understand purpose
                }
                else
                {
                    if (Number == 2)
                    {
                        //Console.WriteLine("It is a Snake"); //This for understand purpose
                        //Its a lader so move backward that means position  will we decrement with respect to Number
                        Position -= Number;
                        //(UC4 requirement)if player position moves below 0,then then player restart from 0
                        if (Position < 0)
                        {
                            Position = 0;
                        }

                    }
                    else
                    {
                        //Console.WriteLine("It is a Ladder");//This for understand purpose
                        //Its a lader so move forward that means position  will we incremented with respect to Number
                        Position += Number;
                        //(UC5 requirement)Ensure the player get the exact winning position 
                        //That means if player get only "100" means win or stay in the same place until the player get "100"
                        if (Position > 100)
                        {
                            Position -= Number;
                        }
                    }
                }
            }
            Console.Write("\nIt take {0} chaces to win the game ", DieCount);
            Console.Read();
        }
    }
}
