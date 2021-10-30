using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // picks a random number between 0 and 100
            int winNum = r.Next(0, 10);
            // keep track to help know when the game has ended
            bool win = false;
            do
            {
                Console.WriteLine("Guess the number between 0 and 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                // if statement to check if it the right number
                if(i>winNum)
                {
                    Console.WriteLine("Too high guess low.");
                }
                else if(i<winNum)
                {
                    Console.WriteLine("Too low");
                }
                else if(i==winNum)
                {
                    Console.WriteLine("You win");
                    win = true;
                }
            } while (win==false);
        }
    }
}
