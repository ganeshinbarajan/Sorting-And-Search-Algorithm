using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting_And_Search_Algorithms.Sorting;

namespace Sorting_And_Search_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 5, 4, 3 };
            var bubbleSort = new BubbleSort();
            var result = bubbleSort.Sorting(input);
            Console.Write(input);
            Console.ReadLine();
        }
    }
}
