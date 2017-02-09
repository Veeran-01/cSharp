using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{

    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        public void addMeal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }


        public static void cookMeal(Meal meal)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
            
        }
    }


    public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
           
        }
    }

    public class Account
    {
        //convention should be _balance
        private static decimal balance;
        
        public static decimal AccountBalance(Meal meal, decimal balance)
        {
            balance +=  meal.price;
            balance -= meal.cost;

            return balance;
            
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            decimal balance = 0;

            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);

            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);

            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);

            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            //This balance will be passed in as a parameter the next time AccountBalance is called
            balance= Account.AccountBalance(steak, balance);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            balance= Account.AccountBalance(pumpkinRisotto, balance);

            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);

        }
    }
}