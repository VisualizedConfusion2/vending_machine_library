using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine_library.Models
{
    public class Slot
    {
        public List<Product> Products = new List<Product>(); // List of products
        public int Price; // Price for the product

        public int GetProductCount() // Returns the number of products in the slot
        {
            return Products.Count;
        }

        public Product EjectProduct() // Gives the product to the user
        {
            Product product = Products[0];
            Products.RemoveAt(0);
            return product;
        }

        public void FillProduct(Product product) // Fills a new product in the slots
        {
            if(Products.Count < 8) // Product cap is 8
            {
                Products.Add(product);
            }
            // Todo: Add custom exception when product cap has reached
        }
    }
}
