using System.Collections.Generic;
using vending_machine_library.Models;

namespace vending_machine_library.Interfaces
{
    public class TransactionRepo : ITransactionRepo
    {
        public void Add(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transaction GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetByProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
