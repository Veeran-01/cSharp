using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersIntoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create an array allow user to aadd 5 numbers to the array
            //and calculate average
            int[] numbers = new int[5];
            int i;
            Console.WriteLine("Please enter five numbers to be averaged.");

            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(numbers[i]);

            }

            //Need to declare as double otherwise average will only give you integer
            double sum = numbers.Sum();
  
            Console.WriteLine(sum);
            double average = (sum / numbers.Length);

            Console.WriteLine(average);

            //2. Extension- Create a 5 X 5 array, fill it with numbers and sum each row and each column then calculate total 
            //of the numbers in the array
            int[,] twoDimensionalArray = new int[5, 5];

            








        }
    }
}
