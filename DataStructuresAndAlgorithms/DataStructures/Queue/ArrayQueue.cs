using Array;
using Queue.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class ArrayQueue<T>:IQueue<T>
    {
        //private List<T> _innerArray;
        private Array<T> _InnerArray;
        public ArrayQueue()
        {
         //_innerArray= new List<T>();
         _InnerArray= new Array<T>();
        }
        public ArrayQueue(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                Enqueue(item);
            }
        }

        public int Count =>_InnerArray.Count;

        public T Dequeue()
        {
         if(Count == 0)
                throw new Exception("The queue is empty!");
         var temp = _InnerArray.RemoveItem(0);
            return temp;
        }

        public void Enqueue(T item)
        {
           _InnerArray.Add(item);
        }

        public T Peek()
        {

            return Count == 0 ? default : _InnerArray.GetItem(0);
        }
    }
}
