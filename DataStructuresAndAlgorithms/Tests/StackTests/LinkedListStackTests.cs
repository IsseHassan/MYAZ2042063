using Stack;

namespace StackTests
{
    public class LinkedListStackTests
    {
        [Fact]
        public void LinkedListStack_Push_Test()
        {
            var stack = new LinkedListStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
           
        
            Assert.Equal(stack.Count, 3);
        }
        [Fact]
        public void LinkedListStack_Pop_Test()
        {
            var stack = new LinkedListStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var result = stack.Pop();

            Assert.Equal(stack.Count, 2);
            Assert.Equal(result, 3);
        }

        [Fact]
        public void LinkedListStack_Peek_Test()
        {
            // arrange    
            var stack = new LinkedListStack<string>();
            stack.Push("Ahmet");
            stack.Push("Fatma");
            stack.Push("Can");

            var result = stack.Peek();


            // Assert
            Assert.Equal(3, stack.Count);
            Assert.Equal("Can", result);

        }
    }
}