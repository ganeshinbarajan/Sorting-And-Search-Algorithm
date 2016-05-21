using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithms.Sorting
{
    public class BubbleSort
    {
        public List<int> Sorting(List<int> itemsList)
        {
            var result = new List<int>();
            int temp;
            for(var i=0;i<itemsList.Count-1;i++)
            {
                for(var j=0;j<itemsList.Count-1;j++)
                {
                    if (itemsList[j] > itemsList[j+1])
                    {
                        temp = itemsList[j];
                        itemsList[j] = itemsList[j+1];
                        itemsList[j+1] = temp;
                    }

                }
            }
            return itemsList;
        }
    }
}
