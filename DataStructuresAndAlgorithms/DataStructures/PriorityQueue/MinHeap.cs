using PriorityQueue;

namespace PriorityQueue
{
    public class MinHeap<T> : BHeap<T> where T : IComparable
    {
       public MinHeap(int size = 128) : base(size) { }
        public MinHeap(IEnumerable<T> collection) : base(collection) { }

        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index)&&
                    GetRightChild(index).CompareTo(GetLeftChild(index)) > 0)
                {
                    break;
                }
                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        protected override void HeapifyUp()
        {
            var index = Position - 1;
            while(!IsRoot(index)&&
                Array.GetValue(index).CompareTo(GetParent(index)) < 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}