namespace vending_machine_library.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Itemname { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product() { } //def constructor

        public Product(int id, string itemname, decimal price, int quantity)
        {
            Id = id;
            Itemname = itemname;
            Price = price;
            Quantity = quantity;
        }
    }
}
