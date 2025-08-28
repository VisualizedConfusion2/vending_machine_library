namespace vending_machine_library.Models
{
    public class Vendingmachine
    {
        // List of slots inside the vending machine
        public List<Slot> Slots { get; set; }

        public Vendingmachine()
        {
            Slots = new List<Slot>();
        }
    }
}
