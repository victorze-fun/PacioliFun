using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacioli.Entities
{
    public class Entry
    {
        public Entry(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }
    }
}
