using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithm.Sorting
{
    public class BubbleSort
    {
        public List<int> Sorting(List<int> itemsList)
        {
            var result = new List<int>();
            int temp;
            for(var i=0;i<itemsList.Count;i++)
            {
                for(var j=1;j<itemsList.Count;j++)
                {
                    if (itemsList[i] > itemsList[j])
                    {
                        temp = itemsList[i];
                        itemsList[i] = itemsList[j];
                        itemsList[j] = temp;
                    }

                }
            }
            return result;
        }
    }
}
