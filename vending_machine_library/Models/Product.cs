namespace vending_machine_library.Models
{
    public class Product
    {
        public int Id { get; set; }            // Unique identifier
        public string Name { get; set; }       // Product name
        public decimal Price { get; set; }     // Product price
        public int Quantity { get; set; }      // How many items are available

        public Product() { } //def constructor

        public Product(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
