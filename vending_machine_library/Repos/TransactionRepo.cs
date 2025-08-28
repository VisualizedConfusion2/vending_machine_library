using System.Collections.Generic;
using vending_machine_library.Models;

namespace vending_machine_library.Interfaces
{
    public interface ITransactionRepo
    {
        List<Transaction> GetAll();                // Get all transactions
        void Add(Transaction transaction);         // Record a new transaction
        Transaction GetByID(int id);               // Find a specific transaction
        List<Transaction> GetByProduct(int productId); // Get all transactions for a product
    }
}
