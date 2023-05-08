using Stack.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;
        public Stack()
        {
                _stack = new LinkedListStack<T>();
        }
        public int Count => _stack.Count;

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Pop()
        {
            return _stack.Peek();
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }
    }
}
