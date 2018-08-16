using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    class ListNode<T>
    {
        public int Data;
        public ListNode<T> Next;
        public ListNode(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
