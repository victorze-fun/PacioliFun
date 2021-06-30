using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pacioli.Entities.Tests
{
    public class TransactionTest
    {
        [Fact]
        void TwoEntries_Balance()
        {
            var transaction = new Transaction();
            var debit = new Entry(100M);
            var credit = new Entry(-100M);

            transaction.AddEntry(debit);
            transaction.AddEntry(credit);

            Assert.True(transaction.Balance());
        }

        [Fact]
        void TwoEntries_NoBalance()
        {
            var transaction = new Transaction();
            var debit = new Entry(90M);
            var credit = new Entry(-100M);

            transaction.AddEntry(debit);
            transaction.AddEntry(credit);

            Assert.False(transaction.Balance());
        }


        [Fact]
        void ThreeEntries_Balance()
        {
            var transaction = new Transaction();
            var debit = new Entry(100M);
            var credit1 = new Entry(-80M);
            var credit2 = new Entry(-20M);

            transaction.AddEntry(debit);
            transaction.AddEntry(credit1);
            transaction.AddEntry(credit2);

            Assert.True(transaction.Balance());
        }

    }
}
