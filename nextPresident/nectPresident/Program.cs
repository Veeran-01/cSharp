using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nectPresident
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Candidates running for President: Donald, Hilary, Bernie, and Ted. Who do you think will win??");

            //Collect user response and convert to lower case so it always matches the switch options
            
            string userGuess = (Console.ReadLine()).ToLower();
            
            switch (userGuess)
            {
                //Need to add break after each statement otherwise will get error
                //can have same response for more than one case
                case "trump":
                case "donald trump":
                case "donald":
                    Console.WriteLine("Correct..");
                    break;

                case "clinton":
                case "hilary clinton":
                case "hilary":
                    Console.WriteLine("Incorrect.. although she would have been their first female president");
                    break;
                case "bernie":
                    Console.WriteLine("Incorrect");
                    break;
                case "ted":
                    Console.WriteLine("Incorrect... and I'm not sure who he is");
                    break;

                //Need a default statement incase they write another name
                default:
                    Console.WriteLine("That isn't one of the candidates...");
                    break;
                
            }
    

    }
                
      
    }
}
