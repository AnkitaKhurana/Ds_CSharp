using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    class MyList<T>
    {
        ListNode<T> Head;
        ListNode<T> Tail;
        int size;
        public MyList()
        {
            Head = null;
            Tail = null;
            size = 0;
        }
        public void Add(int data)
        {
            ListNode<T> newElement = new ListNode<T>(data);
            if (Head == null)
            {
                Head = newElement;
                Tail = newElement;
            }
            else
            {
                Tail.Next = newElement;
                Tail = Tail.Next;
            }
        }
        public ListNode<T> Delete()
        {
            ListNode<T> elementToDelete = Head;
            if (elementToDelete == null)
                return null;
            else
            {
                Head = Head.Next;
                elementToDelete.Next = null;
            }
            return elementToDelete;
        }
        public void Push(int data)
        {
            ListNode<T> newElement = new ListNode<T>(data);
            if (Head == null)
            {
                Head = newElement;
                Tail = newElement;
            }
            else
            {
                newElement.Next = Head;
                Head = newElement;
            }
        }
        public ListNode<T> Pop()
        {
            ListNode<T> elementToDelete = Head;
            if (elementToDelete == null)
                return null;
            else
            {
                Head = Head.Next;
                elementToDelete.Next = null;
            }
            return elementToDelete;
        }
        public ListNode<T> Top()
        {
            ListNode<T> element = Head;
            return element;
        }
        public ListNode<T> End()
        {
            ListNode<T> element = Tail;
            return element;
        }
        public void Display()
        {
            ListNode<T> current = Head;
            while (current!=null)
            {
                Console.Write(current.Data + "-> ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public int Length()
        {
            ListNode<T> current = Head;
            int size = 0;
            while(current!=null)
            {
                size++;
                current = current.Next;
            }
            return size;
        }
        public void Reverse()
        {
            Head = Reverse(Head);
        }
        public void Reverse(int k )
        {

            ListNode<T> remainngListHead = Head;
            int currentK = k;
            if (k >= 2)
            {
                while (currentK != 0)
                {
                    remainngListHead = remainngListHead.Next;
                    currentK--;

                }

                ListNode<T> newHead = Reverse(Head, k);
                ListNode<T> newHeadptr = newHead;
                while (newHeadptr != null)
                {
                    Console.WriteLine("New Head Ptr :" + newHeadptr);
                    if (newHeadptr.Next == null)
                    {
                        newHeadptr.Next = remainngListHead;
                        break;
                    }
                    newHeadptr = newHeadptr.Next;
                }
                Head = newHead;
            }
        }
        private ListNode<T> Reverse(ListNode<T> head)
        {
            if(head.Next == null)
            {
                return head;
            }
            ListNode<T> reversedListhead = head.Next;
            reversedListhead = Reverse(reversedListhead);
            head.Next.Next = head;
            head.Next = null;
            return reversedListhead;
        }
        private ListNode<T> Reverse(ListNode<T> head, int k)
        {
            if (head.Next == null||k==1||k==0)
            {
                return head;
            }
            ListNode<T> reversedListhead = head.Next;
            reversedListhead = Reverse(reversedListhead,k-1);
            head.Next.Next = head;
            head.Next = null;       
               
            return reversedListhead;
        }
    }
}
