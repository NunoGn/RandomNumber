using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100:");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("To High! Guess lower!!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To Low! Guess higher!!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("CONGRATULATIONS!!!! YOU WIN");
                    win = true;
                }

            } while (win == false);
            Console.WriteLine("Thank you for playing this game");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
