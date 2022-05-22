using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6_13_2
{
    public class BinaryHeapTree
    {
        public List<Data> Heap{ get; set; }
        public BinaryHeapTree()
        {
            Heap = new List<Data>();
            Heap.Add(new Data());
        }

        public int Parent(int i)
        {
            return (int)Math.Floor((decimal)i /2);
        }

        public int LeftChild(int i)
        {
            return 2 * i;
        }

        public int RightChild(int i)
        {
            return 2 * i + 1;
        }

        public void Insert(Data data)
        {
            Heap.Add(data);
            SiftUp(Heap.Count - 1);
        }

        public Data FindMaxDistributorByQuantity()
        {
            if(Heap.Count == 1)
            {
                Console.WriteLine("The Tree is empty!");
                return new Data();
            }
            Console.WriteLine(string.Format("Distributor - {0}; Quantity - {1}", Heap[1].Distributor, Heap[1].Quantity));
            return Heap[1];
        }

        private void SiftUp(int i)
        {
            while (i > 1 && Heap[Parent(i)].Quantity < Heap[i].Quantity)
            {
                Data temp = Heap[Parent(i)];
                Heap[Parent(i)] = Heap[i];
                Heap[i] = temp;
                i = Parent(i);
            }
        }
    }
}
