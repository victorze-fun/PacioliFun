using System;

namespace Pacioli.UseCases.Exceptions
{
    public class UnbalancedTransactionException : Exception
    {
        public UnbalancedTransactionException(string message) : base(message)
        {
        }
    }
}
