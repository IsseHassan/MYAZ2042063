using System.Collections;

namespace LinkedList.Singly
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        public SinglyLinkedListNode<T> curr { get; set; }

        public SinglyLinkedListEnumerator()
        {

        }
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T>head)
        {
            Head = head;
            curr = null;
        }
        public T Current => curr.Value ?? default(T);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(Head is null)
            {
                return false;
            }
            if(curr == null)
            {
                curr = Head;
                return true;
            }
            if(curr.Next is not null)
            {
                curr = curr.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Head = null;
            curr = null;
        }
    }
}
