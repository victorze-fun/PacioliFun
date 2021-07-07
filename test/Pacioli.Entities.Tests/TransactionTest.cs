using Xunit;

namespace Pacioli.Entities.Tests
{
    public class TransactionTest
    {
        [Fact]
        void TwoEntries_Balance()
        {
            var transaction = new Transaction();

            transaction.Entries.Add(new Entry(100M));
            transaction.Entries.Add(new Entry(-100M));

            Assert.True(transaction.Balance());
        }

        [Fact]
        void TwoEntries_NoBalance()
        {
            var transaction = new Transaction();

            transaction.Entries.Add(new Entry(90M));
            transaction.Entries.Add(new Entry(-100M));

            Assert.False(transaction.Balance());
        }

        [Fact]
        void ThreeEntries_Balance()
        {
            var transaction = new Transaction();

            transaction.Entries.Add(new Entry(100M));
            transaction.Entries.Add(new Entry(-20M));
            transaction.Entries.Add(new Entry(-80M));

            Assert.True(transaction.Balance());
        }

    }
}
