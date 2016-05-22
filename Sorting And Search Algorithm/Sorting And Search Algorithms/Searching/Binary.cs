using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithms.Searching
{
    public class Binary
    {
        public bool Search(List<int> itemlist, int searchItem)
        {
            int lowBound = 0;
            int highBound = itemlist.Count - 1;
            int midBound = -1;

            while (lowBound <= highBound)
            {
                midBound = lowBound + (highBound - lowBound) / 2;
                if (itemlist[midBound] < searchItem)
                {
                    lowBound = lowBound + 1;
                }
                else if (itemlist[midBound] > searchItem)
                {
                    lowBound = lowBound - 1;
                }
                else if (itemlist[midBound] == searchItem)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
