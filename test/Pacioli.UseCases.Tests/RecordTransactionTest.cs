using Moq;
using Pacioli.Entities;
using Pacioli.UseCases.Exceptions;
using Pacioli.UseCases.Interfaces.Repositories;
using Xunit;

namespace Pacioli.UseCases.Tests
{
    public class RecordTransactionTest
    {
        [Fact]
        void SaveTransaction()
        {
            var transaction = new Transaction();
            transaction.AddEntries(new Entry(100M), new Entry(-100M));
            var mock = new Mock<ITransactionRepository>();
            var recordTransaction = new RecordTransaction(mock.Object);

            recordTransaction.Save(transaction);

            mock.Verify( x => x.Add(transaction), Times.Once);
        }

        [Fact]
        void UnbalancedTransaction_UnbalancedTransactionException()
        {
            var transaction = new Transaction();
            transaction.AddEntries(new Entry(100M), new Entry(-90M));
            var mock = new Mock<ITransactionRepository>();
            var recordTransaction = new RecordTransaction(mock.Object);

            var ex = Assert.Throws<UnbalancedTransactionException>(
                () => recordTransaction.Save(transaction));
            Assert.Equal("Unbalanced: debit 100.00 and credit 90.00", ex.Message);
            mock.Verify( x => x.Add(transaction), Times.Never);
        }
    }
}
