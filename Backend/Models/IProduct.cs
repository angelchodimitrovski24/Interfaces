using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public interface IProduct
    {
        string Title { get; set; }
        bool OrderCompleted { get; }
        void ShipItem(Customer customer);
    }
}
