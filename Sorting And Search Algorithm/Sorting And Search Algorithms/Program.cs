using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting_And_Search_Algorithms.Sorting;
using Sorting_And_Search_Algorithms.Searching;
using Sorting_And_Search_Algorithms.LinkedList;

namespace Sorting_And_Search_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 5, 4, 3 };
            //var bubbleSort = new BubbleSort();
            //var result = bubbleSort.Sorting(input);

            //var quickSort = new QuickSort();
            //var quickSortResult=quickSort.Sort(input);

            //var binarySearch = new Binary();
            //var binarySearchResult = binarySearch.Search(quickSortResult, 5);
            //Console.Write(input);
            //Console.ReadLine();
            TestLinkedList();
        }
        static void TestLinkedList()
        {
            LinkedList.LinkedList Parts = new LinkedList.LinkedList();
            CarPart Part;
            CarPart PartToFind;

            Part = new CarPart();
            Part.PartNumber = 9743;
            Part.PartName = "Air Filter";
            Part.UnitPrice = 8.75;
            Parts.Add(Part);
            
            Part = new CarPart();
            Part.PartNumber = 27487;
            Part.PartName = "Clutch Disk";
            Part.UnitPrice = 47.15;
            Parts.Add(Part);

            Part = new CarPart();
            Part.PartNumber = 87873;
            Part.PartName = "Brake Disk";
            Part.UnitPrice = 35.15;
            Parts.Add(Part);

            Part = new CarPart();
            Part.PartNumber = 27644;
            Part.PartName = "A/C Filter Drier";
            Part.UnitPrice = 55.55;
            Parts.Add(Part);

            Console.WriteLine("Number of Parts: {0}", Parts.Count);

            for (int i = 0; i < Parts.Count; i++)
            {
                CarPart part = Parts.Retrieve(i);
                Console.WriteLine("\nCar Part Information");
                Console.WriteLine("Part #:      {0}", part.PartNumber);
                Console.WriteLine("Description: {0}", part.PartName);
                Console.WriteLine("Unit Price:  {0:C}", part.UnitPrice);
            }
            //Parts.Delete(2);
            PartToFind = new CarPart();
            PartToFind.PartNumber = 87873;
            PartToFind.PartName = "Brake Disk";
            PartToFind.UnitPrice = 35.15;

            bool Found = Parts.Find(PartToFind);
            if (Found == true)
                Console.WriteLine("\nItem was found\n");
            else
                Console.WriteLine("\nItem not found\n");

            Console.WriteLine();


            //return 0;
        }
    }
}
