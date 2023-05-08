using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTests
{
    public class ArrayStackTest
    {
        [Fact]
        public void ArrayStack_push_Test()
        {
            var stack = new ArrayStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.Equal(stack.Count, 3);
        }
        [Fact]
        public void ArrayStack_pop_Test()
        {
            var stack = new ArrayStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            var result = stack.Pop();

            Assert.Equal(result, 30);

            Assert.Equal(stack.Count, 2);
        }
        [Fact]
        public void ArrayStack_peek_Test()
        {
            var stack = new ArrayStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            var result = stack.Peek();

            Assert.Equal(stack.Count, 3);
            Assert.Equal(result, 30);
        }
        [Fact]
        public void ArrayStack_Constructor_IEnumerable_Test()
        {
            var stack = new ArrayStack<int>(new List<int>() { 10, 20, 30 });
            Assert.Equal(stack.Count, 3);
            Assert.Equal(stack.Peek(), 30);
        }
    }
}
