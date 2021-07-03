using Xunit;

namespace Pacioli.Entities.Tests
{
    public class TransactionTest
    {
        [Fact]
        void TwoEntries_Balance()
        {
            var transaction = new Transaction();

            transaction.AddEntries(new Entry(100M), new Entry(-100M));

            Assert.True(transaction.Balance());
        }

        [Fact]
        void TwoEntries_NoBalance()
        {
            var transaction = new Transaction();

            transaction.AddEntries(new Entry(90M), new Entry(-100M));

            Assert.False(transaction.Balance());
        }

        [Fact]
        void ThreeEntries_Balance()
        {
            var transaction = new Transaction();

            transaction.AddEntries(new Entry(100M), new Entry(-80M), new Entry(-20M));

            Assert.True(transaction.Balance());
        }

    }
}
