using System;
using System.Collections;

namespace LinkedList.Doubly
{
    public class DoublyLinkedList<T>:IEnumerable<T>
    {
        public DbNode<T> Head { get; set; }
        public DbNode<T> Tail { get; set; }
        private bool isHeadNull { get; set; }
        public DoublyLinkedList()
        {
            this.isHeadNull = true;
        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            isHeadNull = true;
            foreach (var item in collection)
            {
               AddLast(item);
            }
        }

        public void AddFirst(T item)
        {
            var node = new DbNode<T>(item);
            if (isHeadNull)
            {
                Head= node;
                Tail= node;
                isHeadNull= false;
                return;  // Added! İşlem yapıldıktan sonra return ile kesilmelidir. 
            }
            Head.prev = node;
            node.Next = Head;
            Head = node;
        }
        public void AddLast(T item)
        {
            var node = new DbNode<T>(item);
            if (isHeadNull)
            {
                Head= node;
                Tail= node;
                isHeadNull= false; // Added! İşlem yapıldıktan sonra return ile kesilmelidir. 
                return;
            }
            Tail.Next = node;
            node.prev = Tail;
            Tail = node;
        }

        public T RemoveFirst()
        {
           if(isHeadNull)
                throw new Exception("The linked list is empty");
            T item = default;

            if (Head.Equals(Tail))
            {
                item = Head.Value;
                Head = null;
                Tail = null;
                return item;
            }
            item = Head.Value;
            Head = Head.Next;
            Head.prev = null;
            return item;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new Exception("The linked list is empty");

            if (Tail is null)
                throw new Exception("Tail is null");

            T item = Tail.Value;
            Tail = Tail.prev;
            if (Tail != null)
                Tail.Next = null;
            
            return item;
        }



        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head, Tail);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
