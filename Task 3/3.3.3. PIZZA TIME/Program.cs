using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._3._3.PIZZA_TIME
{
    class Program
    {
        static Customer CheckOrder(Customer customer)
        {
            while (customer.Pizza == null)
            {
                Thread.Sleep(1000);
            }
            return customer;
        }
        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria(1000);

            List<Customer> customers = new List<Customer>()
            {
                new Customer("VLad", 600)
            };

            Console.WriteLine($"Customer: {customers[0].Name} made an order");

            if (customers[0].OrderPizza(pizzeria, TypePizze.MeatPizza))
            {
                Console.WriteLine($"Customer: {customers[0].Name} got pizza " + CheckOrder(customers[0]).Pizza.ToString());
            }
            else 
            {
                Console.WriteLine($"Customer: {customers[0].Name} not enough funds");
            }
            

            Console.ReadKey();
        }
    }
}
