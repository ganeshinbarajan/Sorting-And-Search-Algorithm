using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithms.Searching
{
    public class Linear
    {
        public bool Search(List<int> itemlist,int searchItem)
        {
            foreach(var item in itemlist)
            {
                if (item.Equals(searchItem))
                    return true;
            }
            return false;
        }
    }
}
