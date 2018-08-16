using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    class Heap
    {
        List<int> List;
        int Size;
        public int Parent(int index)
        {
            return index>>1;
        }
        public int Left(int index)
        {
            return index << 1;
        }
        public int Right(int index)
        {
            return index << 1 + 1;
        }
        public Heap()
        {            
            List = new List<int>();
            Size = 0;
            List.Add(-1);
        }
        public void Swap(int a , int b, ref List<int> list)
        {
            int temp = List[a];
            List[a] = List[b];
            List[b] = temp;
            //List[a] = List[a] + List[b];
            //List[b] = List[a] - List[b];
            //List[a] = List[a] - List[b];
        }
        public void AddToHeap(int element)
        {
            List.Add(element);
            Size++;
            int currIndex = Size;
            while (Parent(currIndex) >= 1 && List[Parent(currIndex)]>List[currIndex])
            {
                Swap(currIndex, Parent(currIndex), ref List);                
                currIndex = Parent(currIndex);
            }            
        }
        public void DeleteMinElement()
        {
            if (Size == 0)
                return;
            int lastindex = Size;
            Swap(0, lastindex,ref List);
            List.RemoveAt(lastindex);
            Size--;
            Heapify(1);
        }
        public int Top()
        {
            return List[0];
        }
        public void Display()
        {
            for(int i = 1; i <=Size; i++)
            {
                Console.Write(List[i] + " ");
            }
            Console.WriteLine();
        }
        public void Heapify(int index)
        {
            int minIndex = index;
            if (List[index] > List[Left(index)])
            {
                minIndex = Left(index);
            }
            if(List[minIndex] > List[Right(index)])
            {
                minIndex = Right(index);
            }
            if (minIndex != index)
            {
                Swap(minIndex, index,ref List);
            }
        }
    }
}
