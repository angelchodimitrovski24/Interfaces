using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class DigitalProduct : IProduct, IDigitalProduct 
    {
        public string Title { get; set; }
        public bool OrderCompleted { get; set; }
        public int TotalDownloadsLeft { get; private set; } = 5;
        public void ShipItem(Customer customer)
        {
            if (OrderCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.Email}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    OrderCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
