using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedCars
{
    //Create car class outside of program class- shouldn't have classes inside other classes
    class Vehicle
    {
        //non-static properties- belong to instances of vehicle
        public string make;
        public string model;
        public int price;
        public bool sold;
        public string type;

        //static property- belongs to Car CLASS as a whole
        public static int carsSold;
        public static int carsInStock;
        public static int motorbikesSold;
        public static int motorbikesInStock;
        
        //Vehicle constructor
        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        }

        //SellVehicle method
        public void SellVehicle(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;

            if (type == "car")
            {
                Car.carsSold++;
                Car.carsInStock--;
            }
            else
            {
                Motorbike.motorbikesSold++;
                Motorbike.motorbikesInStock--;
            }
        }

        //To list vehicles method- individual vehicles
        public void ListVehicle()
        {
            Console.WriteLine("This {0} is a {1}, {2} and it is valued at £{3:N0}", this.type, this.make, this.model, this.price);

        }

        //To show details of all vehicles
        public static void VehicleList(List<Vehicle> allVehicles)
        {

            int total = allVehicles.Count;
            int soldValue = 0;
            int stockValue = 0;

            //total= number of cars on record
            Console.WriteLine("There are " + total + " vehicles on record.");
            foreach (Vehicle vehicle in allVehicles)
            {
                Console.WriteLine("There is a {0}, {1} {2} and is valued at £{3:N0}", vehicle.make, vehicle.model, vehicle.type, vehicle.price);

                if (vehicle.sold == true)
                {
                    if (vehicle.type == "car")
                    {
                        Console.WriteLine("This car has been sold");
                        //Add value car sold for to soldValue
                        soldValue += vehicle.price;
                    }
                    else
                    {
                        Console.WriteLine("This motorbike has been sold.");
                        soldValue += vehicle.price;
                    }
                }
                else
                {
                    if (vehicle.type == "car")
                    {
                        Console.WriteLine("This car hasn't been sold.");
                        //add value of car to stock value if it hasn't been sold
                        stockValue += vehicle.price;
                    }
                    else
                    {
                        Console.WriteLine("This motorbike hasn't been sold.");
                        stockValue += vehicle.price;
                    }
                }
            }

            Console.WriteLine("The total value of vehicles sold is {0:N0} ", soldValue);
            Console.WriteLine("The total value of vehicles unsold is {0:N0} ", stockValue);
        }


    }

    //Create class Car that inherits from Vehicle- i.e. can use its methods
    class Car : Vehicle
    {
        public Car(string make, string model, int price) : base(make, model, price)
        {
        //when create instance of car type="car"
        this.type = "car";
        //When new car is created number of cars in stock increases.
        carsInStock++;
        }


    //Create class Motorbikes- which inherits from (:) vehicles
    }
        class Motorbike: Vehicle
        {
            public Motorbike(string make, string model, int price) : base(make, model, price)
            {
            this.type = "Motorbike";
            //When new motorbike is created number of motorbikes in stock increases.
            motorbikesInStock++;
            }
        }

//Main program:
        class Program
        {
            static void Main(string[] args)
            {
            //Initialise non-static variables
            Car.carsInStock = 0;
            Motorbike.motorbikesInStock = 0;
            Car.carsSold = 0;
            Motorbike.motorbikesSold = 0;

            //Create list that will contain all vehicles on record
            List<Vehicle> allVehicles = new List<Vehicle>();
            
            //Add vehicles and add them to list allVehicles
            Car car1 = new Car("Suzuki", "Alto", 5000);
            allVehicles.Add(car1);
            Car car2 = new Car("Ford", "Fiesta", 1000);
            allVehicles.Add(car2);
            Car car3 = new Car("Rolls Royce", "Silver Cloud", 35000);
            allVehicles.Add(car3);
            Car car4 = new Car("Suzuki", "Swift", 10000);
            allVehicles.Add(car4);
            Motorbike motorbike1 = new Motorbike("SuzukiBike", "cloud", 20000);
            allVehicles.Add(motorbike1);

            //If vehicle sold then call soldVehicle method
            car1.SellVehicle(true, 5000);
            car2.SellVehicle(true, 700);
            car3.SellVehicle(true, 35000);
            motorbike1.SellVehicle(true, 20000);
            
            //Display values of the objects
            Console.WriteLine("The total number of cars in stock is " + Car.carsInStock);
            Console.WriteLine("The total number of cars sold is " + Car.carsSold);
            Console.WriteLine("The total number of motorbikes in stock is " + Motorbike.motorbikesInStock);
            Console.WriteLine("The total number of motorbikes sold is " + Motorbike.motorbikesSold);

            //Call ListVehicle
            motorbike1.ListVehicle();

            Vehicle.VehicleList(allVehicles);
            }
        }
    }

