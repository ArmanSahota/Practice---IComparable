using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable
{
    internal class SortingClass1 : IComparer<Headphones>
    {
        public int Compare(Headphones x, Headphones y)
        {
            // Choose a field to sort by (e.g., QBand)
            return string.Compare(x.QBand, y.QBand, StringComparison.OrdinalIgnoreCase);
        }
    }
}
