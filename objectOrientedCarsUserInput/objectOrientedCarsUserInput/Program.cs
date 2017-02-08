using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedCarsUserInput
{
    class Car
    {
        //non-static properties- belong to instances of Car
        public string make;
        public string model;
        public int price;

        //Car constructor- INSIDE Car class
        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
        }

    }
    
        class Program
        { 
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            //My variables
            char userInput;
            string make;
            string model;
            int price;

            Console.WriteLine("Please type 'A' to add a car to the list or 'X' to exit");
            userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                
                //if (userInput == 'A')
                //{
                Console.WriteLine("What is the make of the car you wish to add?");
                make = Console.ReadLine();
                Console.WriteLine("What is the model of the car you wish to add?");
                model = Console.ReadLine();
                Console.WriteLine("What is the price of the car you wish to add?");
                price = Convert.ToInt32(Console.ReadLine());
                    
                //Create new instance of Car with properties just added by the user- Using CONSTRUCTOR
                Car userCar = new Car(make, model, price);
                    
                //Add car to list
                myCars.Add(userCar);

                //Display all cars in list
                foreach (Car car in myCars)
                {
                //\t adds tab, \n adds new line, :N0 adds comma between 000 in numbers
                     Console.WriteLine("Car make:\t{0} \nCar model:\t{1} \nCar price:\t£{2:N0}\n",
                     car.make, car.model, car.price);
                 }

                Console.WriteLine("Please type 'A' to add a car to the list or 'X' to exit");
                userInput = Convert.ToChar(Console.ReadLine().ToUpper());

                //}

            } while (userInput != 'X');


        }
    }
}
