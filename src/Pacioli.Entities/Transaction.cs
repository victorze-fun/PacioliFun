using System.Collections.Generic;
using System.Linq;

namespace Pacioli.Entities
{
    public class Transaction
    {
        public IList<Entry> _entries = new List<Entry>();

        public bool Balance()
        {
            var amounts = from e in _entries select e.Amount;
            return amounts.Sum() == 0;
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }
    }
}
