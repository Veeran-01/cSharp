using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopRiddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string userGuess;
            
            string myAnswer;
            Console.WriteLine("What type of band doesn't play music?");

            myAnswer = "elastic band";
            userGuess = (Console.ReadLine()).ToLower();

            //do while loop:

            //do
            //{
            //    Console.WriteLine("What type of band doesn't play music?");
            //    userGuess = (Console.ReadLine()).ToLower();

            //} while (userGuess != myAnswer && userGuess !="i give up");

            //Console.WriteLine("Correct");

            //while loop:
            while (userGuess != myAnswer && userGuess != "i give up")
                {
                
                    Console.WriteLine("Incorrect try again");
                    userGuess =(Console.ReadLine()).ToLower();
                }

            //Allow an escape if they give up:

            if (userGuess != "i give up")
                {
                    Console.WriteLine("correct");
                }
            else
                {
                    Console.WriteLine("The correct answer is " + myAnswer);
                }

        }
    }
}
