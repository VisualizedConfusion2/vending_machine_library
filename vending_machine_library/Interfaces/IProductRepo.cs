using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vending_machine_library.Models;

namespace vending_machine_library.Interfaces
{
    internal interface IProductRepo
    {
        List<Product> GetAll(); // List for all Product

        void Add(Product product); // Adds a product to the repo

        Product GetByID(int id); // Gets a specific product from the ID
    }
}
