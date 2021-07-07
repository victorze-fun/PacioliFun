using Pacioli.Entities;
using Pacioli.UseCases.Interfaces.Repositories;

namespace Pacioli.Services.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public void Add(Transaction transaction)
        {
            using var db = new ApplicationDbContext();
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }
   }
}
