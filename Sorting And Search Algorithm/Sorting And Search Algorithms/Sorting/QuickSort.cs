using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithms.Sorting
{
    public class QuickSort
    {
        public List<int> Sort(List<int> itemlist)
        {
            var result = new List<int>();
            var less = new List<int>();
            var greater = new List<int>();

            if (itemlist.Count <= 1)
                return itemlist;

            Random r = new Random();
            var posPivot = r.Next(itemlist.Count);
            var pivot = itemlist[posPivot];
            itemlist.RemoveAt(posPivot);
            

            for(var i=0;i<itemlist.Count;i++)
            {
                if (itemlist[i] <= pivot)
                    less.Add(itemlist[i]);
                else
                    greater.Add(itemlist[i]);
            }

            result = concat(Sort(less), pivot, Sort(greater));

            return result;
        }
        public List<int> concat(List<int> less,int pivot,List<int> greater)
        {
            var result = new List<int>();
            result = less;
            result.Add(pivot);
            foreach(var item in greater)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
