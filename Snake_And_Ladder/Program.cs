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
            //FPosition Means First Player Position
            int FPosition = 0;
            //SPosition Means Second Player Position
            int SPosition = 0;
            //The Loop Will Run until Any One Player Reaches the 100
            while(FPosition != 100 && SPosition != 100)
            {
                //In this every time the position will update depending upon the return value
                FPosition = GetMyPos(FPosition);
                SPosition = GetMyPos(SPosition);
            }
            //Depending upon there position it will tell who is the winner
            if(SPosition>FPosition)
            {
                Console.WriteLine("\nCONGRATULATION\nSecond Player WON the game");
            }
            else
            {
                Console.WriteLine("\nCONGRATULATION\nFirst Player WON the game");
            }
            Console.Read();
            
        }
        //This Method Will Take The Current Position Of The Player Eevery Time And Give The Updated Position
        public static int GetMyPos(int Temp)
        {
            int Position = Temp;
            Random random = new Random();
        Again:
            int choice = random.Next(1, 7);
            if(choice == 5 )
            {
                //NO play The Player Stay In Same Position
            }
            else
            {
                if(choice == 2 || choice == 4 )
                {
                    //It's a snake The Player Will Go Back Some Steps
                    Position -= choice;
                    if(Position < 0)
                    {
                        Position = 0;
                    }
                }
                else
                {
                    //Its a lader The Player Will Go Move Some Steps
                    Position += choice;
                    if(Position > 100)
                    {
                        Position -= choice;
                    }
                    //If he get a lader he will get a chance again
                    goto Again;

                }
            }
            return Position;
        }

    }
}
