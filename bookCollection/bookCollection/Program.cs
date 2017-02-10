using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookCollection
{
    class Book
    {
        //Each book should have the attributes of title, author, ISBN and price
        //My variables
        public string title;
        public string author;
        public int ISBN;
        public double price;

        //Book constructor
        public Book(string title, string author, int ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //My variables
            char userInput;
            string title;
            string author;
            int ISBN;
            double price;
            string titleToDelete;
            string titleToSearch;

            //Create list of books
            List<Book> bookCollection = new List<Book>();
            List<Book> SortedList = new List<Book>();
            do
            {
                Console.WriteLine("To add a book to the book collection enter 'A', to delete a book 'D', \n to Find a book 'F', to sort books according to title 'S', to list all 'L' and to exit enter 'X'.");
                userInput = Convert.ToChar(Console.ReadLine().ToUpper());

                switch(userInput)
                {
                    //Add book
                    case 'A':
                        //Collect attributes of the book
                        Console.WriteLine("What is the title of the book?");
                        title = Console.ReadLine();
                        Console.WriteLine("Who is the author of the book?");
                        author = Console.ReadLine();
                        Console.WriteLine("What is the ISBN of the book?");
                        ISBN = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How much does the book cost?");
                        price = Convert.ToDouble(Console.ReadLine());

                        //Create a book object- using attribute just collected
                        Book userBook = new Book(title, author, ISBN, price);

                        //add book to list
                        bookCollection.Add(userBook);
                        break;
                        
                        //List all
                    case 'L':
                        //Use foreach loop to list all items in the collection
                        Console.WriteLine("These are the books in the list:");

                        //Check if list has been sorted- if so display sorted list
                        if (SortedList.Count != 0)
                        {
                            foreach (Book book in SortedList)
                            {
                                Console.WriteLine("\t {0} by {1} with ISBN No. {2} and is currently valued at {3}.",
                                    book.title, book.author, book.ISBN, book.price);
                            }

                        }
                        else
                        {   
                            foreach (Book book in bookCollection)
                            {
                                Console.WriteLine("\t {0} by {1} with ISBN No. {2} and is currently valued at {3}.",
                                    book.title, book.author, book.ISBN, book.price);
                            }
                        }
                        break;

                        //Sort books
                     case 'S':
                     //Create new list for sorted books
                     SortedList = bookCollection.OrderBy(o => o.title).ToList();
                     Console.WriteLine("\n The book collection has now been sorted by title \n");
                     break;


                        //Delete a book
                    case 'D':
                        Console.WriteLine("What is the title of the book you wish to delete?");
                        titleToDelete = Console.ReadLine();
                        Book removeBook = bookCollection.Find(l => l.title == titleToDelete);
                        bookCollection.Remove(removeBook);
                        Console.WriteLine("{0} has been removed from your book collection.\n", titleToDelete);
                        break;


                        //to search for a book
                    case 'F':
                        Console.WriteLine("What is the title of the book you are searching for?");
                        titleToSearch = Console.ReadLine();
                        Book searchBook = bookCollection.Find(l => l.title == titleToSearch);

                        Console.WriteLine("\n\t {0} by {1} with ISBN No. {2} and is currently valued at {3}.",
                                    searchBook.title, searchBook.author, searchBook.ISBN, searchBook.price);
                        break;
                }
                
                
            } while (userInput != 'X');
        }
    }
}
