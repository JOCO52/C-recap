using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Guess the Number By Logan Weeden");
            Console.WriteLine("");
            Console.WriteLine("Guess A Randomly gnerated number");
            bool game = true;
            while (game == true)
            {
                Console.WriteLine("generating new number");
                Random rand = new Random();
                int NoofAttempts = 0;
                int ranNumber = rand.Next(1, 100);
                Console.WriteLine("the number is " + ranNumber);

                Console.WriteLine("enter a guess between 1 and 9");
                int Guess = Convert.ToInt32(Console.ReadLine());
                NoofAttempts = NoofAttempts + 1;
                Console.WriteLine("Youe Guessed " + "" + Guess);

                while (Guess != ranNumber)
                {
                    Console.WriteLine("Wrong Try Again");

                    if (ranNumber < Guess)
                    {
                        Console.WriteLine("Guess Lower");
                    }
                    else
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    //Read a new guess from the player
                    Console.WriteLine("enter a guess between 1 and 100");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    while (Guess > 99 || Guess < 1)
                    {
                        Console.WriteLine("please enter a valid answer");
                        Guess = Convert.ToInt32(Console.ReadLine());
                    }
                    NoofAttempts = NoofAttempts + 1;

                    if (NoofAttempts == 10)
                    {
                        break;
                    }


                }

                if ( Guess != ranNumber)
                {
                    Console.WriteLine("game Over");
                }

                Console.WriteLine("Correct, it took you " + NoofAttempts + " attempts");

                Console.WriteLine("play again? (Y/N)");
                string replay = Console.ReadLine();
                if (replay == "y")
                {
                    game = true;
                }
                if (replay =="n")
                {
                    game = false;
                }
            }
            
                    

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
