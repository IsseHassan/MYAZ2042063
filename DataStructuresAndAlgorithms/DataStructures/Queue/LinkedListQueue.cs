using LinkedList.Doubly;
using Queue.Contract;

namespace Queue
{
    public class LinkedListQueue<T>:IQueue<T>
    {
        private DoublyLinkedList<T> linkedListQueue;
        public LinkedListQueue()
        {
            linkedListQueue= new DoublyLinkedList<T>();
        }

        public int Count => linkedListQueue.Count();

        public T Dequeue()
        {
            if(linkedListQueue.Head is null)
                throw new Exception("The queue is empty!");
            return linkedListQueue.RemoveFirst();
        }

        public void Enqueue(T item)
        {
             linkedListQueue.AddLast(item);
        }

        public T Peek()
        {
            return linkedListQueue.Head is null ? default(T) : linkedListQueue.Head.Value;
        }
    }
}