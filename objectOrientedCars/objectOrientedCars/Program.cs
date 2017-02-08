using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedCars
{
    //Create car class outside of program class- shouldn't have classes inside other classes
    class Car
    {
        //non-static properties- belong to instances of Car
        public string make;
        public string model;
        public int price;
        public bool sold;
        public string numberPlate;
        public string colour;
        //static property- belongs to Car CLASS as a whole
        public static int carsSold;
        public static int carsInStock;

        //Add car method
        //public void AddCar(string make, string model, int price )
        //{
        //    this.make = make;
        //    this.model = model;
        //    this.price = price;
        //    this.sold = false;
        //    //Everytime they add a car number of cars in stock increases
        //    Car.carsInStock++;
        //}

        //First car constructor - replace addCar method

        public Car (string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.numberPlate = "";
            this.colour = "";
            //Everytime they add a car number of cars in stock increases
            Car.carsInStock++;
        }

        //Different constructor if they have number plate available
        public Car(string make, string model, int price, string numberPlate)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.numberPlate = numberPlate;
            this.colour = "";
            //Everytime they add a car number of cars in stock increases
            Car.carsInStock++;
        }

        //different constructor- if they have colour available and number plate
        public Car(string make, string model, int price, string numberPlate, string colour)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.numberPlate = numberPlate;
            this.colour = colour;
            //Everytime they add a car number of cars in stock increases
            Car.carsInStock++;

        }
        
        //Sell car method- this keyword means whichever instance of car you are calling method on.
        //non-static method- i.e applies only to instances of Car e.g. car1
        public void SellCar(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            Car.carsSold++;
            Car.carsInStock--;
        }

        //To list car- display description
        public void ListCar()
        {
            Console.WriteLine("This car is a {0}, {1} and it sold for £{2:N0}", this.make, this.model, this.price);
            
        }

        //Parameter is the allCars List created in the program
        public static void CarList(List<Car> allCars)
        {
            
            int total = allCars.Count;
            int soldValue = 0;
            int stockValue = 0;
           
            //total= number of cars on record
            Console.WriteLine("There are " + total + " cars altogether.");
            foreach (Car car in allCars )
            {
                if (car.numberPlate != "" ||car.colour !="")
                {
                    if (car.colour == "")
                    {
                        //i.e. has number plate but no colour information available
                        Console.WriteLine("There is a {0}, {1} valued at £{2:N0} and its number plate is {3}",
                            car.make, car.model, car.price, car.numberPlate);
                    }
                    else
                    {
                        Console.WriteLine("There is a {0}, {1} {2} valued at £{3:N0} and its number plate is {4}",
                            car.colour, car.make, car.model, car.price, car.numberPlate);
                    }

                }
                else
                {
                    //i.e. no number plate or colour
                    Console.WriteLine("There is a {0}, {1} and is valued at £{2:N0}", car.make, car.model, car.price);
                }
                if (car.sold == true)
                {
                    Console.WriteLine("This car has been sold");
                    //Add value car sold for to soldValue
                    soldValue += car.price;
                }
                else
                {
                    Console.WriteLine("This car hasn't been sold.");
                    //add value of car to stock value if it hasn't been sold
                    stockValue += car.price;
                }
            }

            Console.WriteLine("The total value of cars sold is {0:N0} ", soldValue);
            Console.WriteLine("The total value of cars sold is {0:N0} ", stockValue);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create list that will contain all cars on record
            List<Car> allCars = new List<Car>();


            //Initiate carsSold
            Car.carsInStock = 0;
            Car.carsSold = 0;

            //Instantiate an object- i.e create an instance of Car

            //calling first constructor
            Car car1 = new Car("Suzuki", "Alto", 5000);
            //Calling AddCar and SellCar methods
            //car1.AddCar("Suzuki", "Alto", 5000);
            car1.SellCar(true, 5000);
            allCars.Add(car1);


            //Console.WriteLine(allCars[0].make);

            //Assign values to non-static properties-WITHOUT using method!
            //car1.make = "Suzuki";
            //car1.model = "Alto";
            //car1.price = 5000;

            //Increment number of cars sold each time
            //Car.carsSold++;

            //second instance of car

            //calling second constructor
            Car car2 = new Car("Ford", "Fiesta", 1000, "L1DMGGH");
            //car2.AddCar("Ford", "Fiesta", 1000);
            car2.SellCar(true, 700);
            allCars.Add(car2);

            //If you didn't have AddCar method:
            //car2.make = "Ford";
            //car2.model = "Fiesta";
            //car2.price = 1000;

            //Car.carsSold++;

            //third instance of car
            //calling third constructor
            Car car3 = new Car("Rolls Royce", "Silver Cloud", 35000, "LC11JJU", "Black");
            //car3.AddCar("Rolls Royce", "Silver Cloud", 35000);
            car3.SellCar(true, 35000);
            allCars.Add(car3);


            Car car4 = new Car("Suzuki", "Swift", 10000);
            //car4.AddCar("Suzuki", "Swift", 10000);
            //car4.SellCar(true, 2000);
            allCars.Add(car4);

            //car3.make = "Rolls Royce";
            //car3.model = "Silver Cloud";
            //car3.price = 35000;

            //Car.carsSold++;

            //Display values of the objects
            Console.WriteLine("The total number of cars in stock is "  + Car.carsInStock);
            Console.WriteLine("The total number of cars sold is " + Car.carsSold);

            //:N0- FORMATTING FOR NUMBERS
            //Console.WriteLine("car1 is a {0}, {1} and it sold for £{2:N0}", car1.make, car1.model, car1.price);
            //Console.WriteLine("car2 is a {0}, {1} and it sold for £{2:N0}", car2.make, car2.model, car2.price);
            //Console.WriteLine("car3 is a {0}, {1} and it sold for £{2:N0}", car3.make, car3.model, car3.price);

            //car1.ListCar();
            //car2.ListCar();
            //car3.ListCar();
            //car4.ListCar();

            Car.CarList(allCars);
        }
    }
}
