using Stack.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private List<T> _InnerArray;
       
        private int LastIndex => Count - 1;
        public ArrayStack()
        {
            _InnerArray = new List<T>();
        }
        public ArrayStack(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                Push(item);
            }
        }
        public int Count => _InnerArray.Count;

        public T Peek()
        {
            return Count == 0
                 ? default(T)
                 : _InnerArray[LastIndex];
        }

        public T Pop()
        {
            if(Count == 0)
            {
                throw new Exception("Underflow! Empty stack!");
            }
            var tempt = _InnerArray[LastIndex];
            _InnerArray.RemoveAt(LastIndex);
            return tempt;
        }

        public void Push(T item)
        {
           _InnerArray.Add(item);
        }
    }
}
