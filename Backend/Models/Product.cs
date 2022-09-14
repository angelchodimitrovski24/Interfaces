using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Product : IProduct
    {
        public string Title { get; set; }
        public bool OrderCompleted { get; set; }
        public void ShipItem(Customer customer)
        {
            if (OrderCompleted==false)
            {
                Console.WriteLine($"Shipping {Title} to {customer.FirstName} in {customer.City}");
                OrderCompleted = true;
            }
        }
    }
}
