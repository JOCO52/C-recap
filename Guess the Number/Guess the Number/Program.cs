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

            Random rand = new Random();
            int ranNumber = rand.Next(1,10);
            Console.WriteLine("the number is " + ranNumber);

            Console.WriteLine("enter a guess between 1 and 9");
            int Guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Youe Guessed " +   "" + Guess);
            if (ranNumber == Guess)
            {
                Console.WriteLine("Correct");
            }

            else
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
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
