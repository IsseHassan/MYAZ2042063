using System.Collections;

namespace LinkedList.Doubly
{
    public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        public DbNode<T> Head { get; set; }
        public DbNode<T> Tail { get; set; }
        public DbNode<T> Curr { get; set; }
        public DoublyLinkedListEnumerator()
        {
        }
        public DoublyLinkedListEnumerator(DbNode<T> head, DbNode<T> tail)
        {
            this.Head = head;
            this.Tail = tail;
            Curr = null;
        }
        public T Current => Curr.Value ?? default(T);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
            Tail = null;
        }

        public bool MoveNext()
        {
         if(Head is null) 
                return false;

         if(Curr is null)
            {
                Curr = Head;
                return true;
            }
         if(Curr.Next is not null)
            {
                Curr = Curr.Next;
                return true;
            }
         return false;
                
        }

        public void Reset()
        {
            Head = null;
            Tail = null;
            Curr = null;
        }
    }
}