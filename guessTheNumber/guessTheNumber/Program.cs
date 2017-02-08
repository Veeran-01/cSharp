using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //tell the user about the program
            Console.WriteLine("I am going to think of a number and you are going to try and guess it");

            //initialise the number and set its value
            int myNumber = 5;

            // initialise the response
            int userGuess;
            char anotherGuess;

            do { 
            //ask the user to enter a number
            Console.WriteLine("What number am I thinking of?");

            //get the response and convert to integer

            userGuess = Convert.ToInt32(Console.ReadLine());

                //check if the number is correct
                if (userGuess == myNumber)
                {
                    Console.WriteLine("Correct!");
                }

                else
                {
                    //Console.WriteLine("Incorrect..");
                    //if it's wrong, then say if it's higher or lower than the correct number
                    if (userGuess < myNumber)
                    {
                        Console.WriteLine("The number I am thinking of is higher than that...");
                    }
                    else
                    {
                        Console.WriteLine("The number I am thinking of is lower than that...");
                    }
                }
                Console.WriteLine("Would you like anoth go?");
                anotherGuess =Convert.To

                
            }while()
            











        }
    }
}
