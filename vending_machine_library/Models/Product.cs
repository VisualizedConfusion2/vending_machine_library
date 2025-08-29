namespace vending_machine_library.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Product() { } //def constructor

        public Product(int id, string name, decimal price, int quantity)
        {
            Name = name;
        }
    }
}
