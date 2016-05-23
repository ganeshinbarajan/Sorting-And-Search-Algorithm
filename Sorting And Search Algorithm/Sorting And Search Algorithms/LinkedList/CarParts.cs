using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_And_Search_Algorithms.LinkedList
{
    class CarPart
    {
        public long PartNumber;
        public string PartName;
        public double UnitPrice;
        public CarPart Next;
    };

    class LinkedList
    {
        private int size;
        private CarPart Head;

        public LinkedList()
        {
            size = 0;
            Head = null;
        }

        public int Count
        {
            get { return size; }
        }

        

        public int Add(CarPart NewItem)
        {
            CarPart Sample = new CarPart();

            Sample = NewItem;
            Sample.Next = Head;
            Head = Sample;
            return size++;
        }

        public CarPart Retrieve(int Position)
        {
            CarPart Current = Head;

            for (int i = 0; i < Position && Current != null; i++)
                Current = Current.Next;
            return Current;
        }

        public bool Delete()
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return false;
            }

            CarPart Current;

            Current = Head.Next;
            Head.Next = Current.Next;
            size--;
            return true;
        }
        public bool Delete(int Position)
        {
            if (this.Retrieve(Position) == null)
                return false;

            this.Retrieve(Position - 1).Next = this.Retrieve(Position + 1);
            size--;
            return true;
        }
        public bool Find(CarPart ItemToFind)
        {
            CarPart Current = new CarPart();

            if (ItemToFind == null)
                return false;

            for (Current = Head; Current != null; Current = Current.Next)
            {
                if ((Current.PartNumber == ItemToFind.PartNumber) &&
                    (Current.PartName == ItemToFind.PartName) &&
                    (Current.UnitPrice == ItemToFind.UnitPrice))
                    return true;
            }

            return false;
        }

    }
}
