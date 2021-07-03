using Pacioli.Entities;
using Pacioli.UseCases.Exceptions;
using Pacioli.UseCases.Interfaces.Repositories;
using System;

namespace Pacioli.UseCases
{
    public class RecordTransaction
    {
        ITransactionRepository _transactionRepository;
        public RecordTransaction(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void Save(Transaction transaction)
        {
            if (transaction.Balance())
            {
                _transactionRepository.Add(transaction);
            }
            else
            {
                throw new UnbalancedTransactionException(
                    $"Unbalanced: debit {transaction.Debit:F2} and credit {transaction.Credit:F2}");
            }
        }
    }
}
