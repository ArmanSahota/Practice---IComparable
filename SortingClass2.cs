using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable
{
    internal class SortingClass2 : IComparer<Headphones>
    {
        public int Compare(Headphones x, Headphones y)
        {
            // Choose a field to sort by (e.g., Cable) in decreasing order
            return string.Compare(y.Cable, x.Cable, StringComparison.OrdinalIgnoreCase);
        }
    }
}
