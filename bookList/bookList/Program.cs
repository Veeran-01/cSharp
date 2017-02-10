using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of books and add some items to the list
            List<string> bookList = new List<string>() { "A fine balance", "The kite runner", "The White Tiger", "Gone Girl" };

            Console.WriteLine("Here is your book collection. To add an item enter 'A', to delete an item enter 'D', to List items enter 'L', to sort items enter 'S', to check for an item enter 'C' and to exit enter 'X'." );

            //Collect user input
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            //Need Do while loop so you can add/delete more than one book- could use while loop but would contain too many ||
            do 
            {
                switch (userInput)
                {
                    case 'A':
                        Console.WriteLine("Please enter the name the book you wish to add.");
                        string bookToAdd = Console.ReadLine();
                        bookList.Add(bookToAdd);
                        break;

                    case 'D':
                        Console.WriteLine("Please enter the name of the book you wish to delete.");
                        string bookToDelete = Console.ReadLine();
                        bookList.Remove(bookToDelete);
                        break;

                    case 'L':
                        Console.WriteLine("Here are the books in your collection");
                        foreach (string i in bookList)
                        {
                            Console.WriteLine(i);
                        }
                        //Instead can do 
                        //bookList.ForEach(Console.WriteLine);
                        break;

                    case 'S':
                        Console.WriteLine("The items in your collection have been sorted alphabetically");
                        bookList.Sort();
                        break;

                    case 'C':
                        //Check if an item's in the list- case insensitive- need .OrdinalIgnoreCase
                        Console.WriteLine("Please enter the book you are searching for");
                        string checkBook = Console.ReadLine();
                        //bool inList = bookList.Contains(checkBook);
                        if (bookList.Contains(checkBook, StringComparer.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Yes that's in the list");
                        }
                        else
                        {
                            Console.WriteLine("No that's not in the list");
                        }

                        break;
                      

                    default:
                        Console.WriteLine("Please enter 'A' to add, 'D' to delete and 'X' to exit. ");
                        break;

                        
                }

                //Need to collect user input again
                Console.WriteLine("Enter 'A' to add, 'D' to delete, 'L' to list, 'S' to sort, 'C' to check and 'X' to exit.");
                userInput = Convert.ToChar(Console.ReadLine().ToUpper());



            } while (userInput != 'X');






        }
    }
}
