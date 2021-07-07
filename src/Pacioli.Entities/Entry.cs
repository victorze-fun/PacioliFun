using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacioli.Entities
{
    public class Entry
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }

        public Entry(decimal amount)
        {
            Amount = amount;
        }

    }
}
