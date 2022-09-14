using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> cart = AddData();
            Customer customer = GetCustomer();

            foreach(IProduct product in cart)
            {
                product.ShipItem(customer);

                if (product is IDigitalProduct digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static Customer GetCustomer()
        {
            return new Customer
            {
                FirstName = "Gabriel",
                LastName = "Dimitrovski",
                City = "San Gwann",
                Email = "gabriel@testemail.com"
                
            };
        }
        private static List<IProduct> AddData()
        {
            List<IProduct> output = new List<IProduct>();

            output.Add(new Product { Title = "Asus Laptop"});
            output.Add(new Product { Title = "Del Laptop" });
            output.Add(new Product { Title = "HP Laptop" });
            output.Add(new DigitalProduct { Title = "Interfaces in C#" });
            return output;
        }
    }
}
