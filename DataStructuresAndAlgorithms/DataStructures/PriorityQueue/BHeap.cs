using DataStructures.Array;
using System.Collections;

namespace PriorityQueue
{
    public abstract class BHeap<T>:IEnumerable<T> where T:IComparable
    {
        public Array<T> Array { get; private set; }

        protected int Position;

        public int Count { get; private set; }

        public BHeap(int _size = 128)
        {
            Count = 0;
            Position = 0;
            Array = new Array<T>(_size);
        }
        public BHeap(IEnumerable<T> collection):this(collection.ToArray().Length)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        

        public int GetLeftChildIndex(int i) => 2 * i + 1;
        protected int GetRightChildIndex(int i) => 2 * i + 2;
        public int GetParentIndex(int i) => (i - 1) / 2;

        protected bool HasLeftChild(int i) =>
         GetLeftChildIndex(i) < Position;
        protected bool HasRightChild(int i )=>
            GetRightChildIndex(i) < Position;

        protected bool IsRoot(int i) => i == 0;

        protected T GetLeftChild(int i) =>
           Array.GetValue(GetLeftChildIndex(i));
        protected T GetRightChild(int i) =>
            Array.GetValue(GetRightChildIndex(i));

        protected T GetParent(int i) =>
           Array.GetValue(GetParentIndex(i));

        public bool IsEmpty() => Position == 0;

        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Empty heap!");
            return Array.GetValue(0);
        }

        public void Swap(int first, int second)
        {
            var temp = Array.GetValue(first);
            Array.SetValue(Array.GetValue(second), first);
            Array.SetValue(temp, second);
        }

        public void Add(T value)
        {
            //if (position == Array.Length)
            //    throw new IndexOutOfRangeException("Overflow!");
            Array.SetValue(value, Position);
            Position++;
            Count++;
            HeapifyUp();
        }
        public T DeleteMinMax()
        {
            if (Position == 0)
                throw new IndexOutOfRangeException("Underflow!");
            var temp = Array.GetValue(0);
            Array.SetValue(Array.GetValue(Position - 1), 0);
            Position--;
            Count--;
            HeapifyDown();
            return temp;
        }

        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();

        public IEnumerator<T> GetEnumerator()
        {
            return Array.Take(Position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}