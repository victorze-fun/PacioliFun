using Pacioli.Entities;

namespace Pacioli.UseCases.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
    }
}
