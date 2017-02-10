using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            //My variables;
            char userInputAdd;
            double userNumber;
            char userOption;
            double sum;
            double average;
            double averageMedian;
            double median;
            double total;
            //Need to create list of integers
            List<double> numberList = new List<double>();

            
            //Create do while loop- as long as user input is Y
            do
            {
                //Display options to the user
                Console.WriteLine("Would you like to add a number to the list?");

                //Collect user input
                userInputAdd = Convert.ToChar(Console.ReadLine().ToUpper());
                
                //Create if statement to add number to list is Y
                if (userInputAdd=='Y')
                {
                    //Ask for number they wish to add
                    Console.WriteLine("Enter the number you wish to add");
                    //Collect number
                    userNumber = Convert.ToDouble(Console.ReadLine());
                    //Add number to list
                    numberList.Add(userNumber);

                }

            } while (userInputAdd == 'Y');
            
            do
            {
                //display options
                Console.WriteLine("Type ‘A’ to get the average of the list, ‘S’ to sort it, 'D' to display, 'M' for median, 'T' for total sum or ‘X’ to exit:");

                //collect user option
                userOption = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (userOption)
                {
                    case 'A':
                        //Calculate average
                        sum = numberList.Sum();
                        average = sum / numberList.Count;
                        //Display average
                        Console.WriteLine("The average of the numbers in the list is {0}", average);
                        break;

                    case 'S':
                        //Sort list
                        numberList.Sort();
                        Console.WriteLine("The list has been sorted");
                        break;

                    case 'D':
                        //display list with foreach loop
                        Console.WriteLine("List of numbers:");
                        foreach (double number in numberList)
                        {
                            Console.WriteLine("\n" +number);
                        }
                        break;

                    case 'M':
                        //sort
                        //check if length of list is even or odd- i.e. is divisible by two with no remainders
                        numberList.Sort();
                        if (numberList.Count % 2 == 0)
                        {
                            //get average of  middle TWO numbers:
                            averageMedian= (numberList[(numberList.Count/2)-1] + (numberList[(numberList.Count/2)]))/2;

                            //Console.WriteLine(numberList[numberList.Count / 2]);
                            //Console.WriteLine(numberList[(numberList.Count / 2)-1]);
                            Console.WriteLine("The median of this list is: {0}", averageMedian);
                        }
                        else
                        {
                            //go to middle number- can divide list length by two because will round up if decimal
                            median = numberList[numberList.Count / 2];
                            Console.WriteLine("The median fo this list is {0}", median);
                        }
                        break;

                    case 'T':
                        //Initialise total
                        total = 0;
                        foreach (double number in numberList)
                        {
                            //Add each number to the total
                            total += number;
                        }
                        Console.WriteLine("The sum of numbers in the list is: {0}", total);
                        break;

                    default:
                        Console.WriteLine("Type ‘A’ to get the average of the list, ‘S’ to sort it, or ‘X’ to exit:");
                        break;

                        
                } 
            } while (userOption != 'X');


        }

    }
}
