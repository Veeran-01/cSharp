using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception for indexing out of array range

            int[] numbers = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i=0; i<= 5; i++)
                {
                    Console.WriteLine(numbers[i]);
                }                
            }
            //could write Exception if not a common exception and then write an error message for it.
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Catch block \t " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block:\t The length of the array is " + numbers.Length);
            }


            //Divide by zero exception

            int Zero = 0;
            int One = 1;

            try
            {
                int divideByZero = One / Zero;
                Console.WriteLine(divideByZero);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Catch block: \t " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block: \t Can't divide one by zero");
            }

            //Array 

            int[] mismatchArray = new int[1];

            try
            {
                mismatchArray[2] = 2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Catch block: \t " + e.Message);
            }
            finally
            {
                Console.WriteLine("finally: The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. For example, if you open a file, it must be closed whether an exception is raised or not.");
            }








        }
    }
}
