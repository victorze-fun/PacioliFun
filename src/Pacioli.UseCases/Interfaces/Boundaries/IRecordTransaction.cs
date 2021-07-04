using Pacioli.Entities;

namespace Pacioli.UseCases.Interfaces.Boundaries
{
    public interface IRecordTransaction
    {
        void Save(Transaction transaction);
    }
}
