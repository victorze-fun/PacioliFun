using Pacioli.Entities;
using Pacioli.UseCases.Interfaces.Repositories;
using System;

namespace Pacioli.Services.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public void Add(Transaction transaction)
        {
            Console.WriteLine("La Transacción se almacenó en la base de datos.");
        }
    }
}
