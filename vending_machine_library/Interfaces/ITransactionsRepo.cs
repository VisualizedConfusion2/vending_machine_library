using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vending_machine_library.Models;

namespace vending_machine_library.Interfaces
{
    public interface ITransactionsRepo
    {
        List<Transaction> GetAll(); // Get all transactions
        void Add(Transaction transaction); // Record a new transaction
        Transaction GetByID(int id); // Find a specific transaction
        List<Transaction> GetByProduct(int productId); // Get all transactions for a product
    }
}