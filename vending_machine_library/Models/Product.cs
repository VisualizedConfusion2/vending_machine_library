namespace vending_machine_library.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Product() { } //def constructor

        public Product(string name)
        {
            Name = name;
        }
    }
}
