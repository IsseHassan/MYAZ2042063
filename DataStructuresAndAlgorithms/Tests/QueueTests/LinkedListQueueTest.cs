using Queue;

namespace QueueTests
{
    public class LinkedListQueueTest
    {
        [Fact]
        public void Queue_Enqueue_Test()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.Peek());
        }
        [Fact]
        public void Queue_Dequeue_Test()
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
            Assert.Equal(4, queue.Dequeue());
            Assert.Equal(5, queue.Dequeue());  
        }
        [Fact]
        public void Queue_equeue_Exception_Test()
        {
            var queue = new LinkedListQueue<int>();

            Assert.Throws<Exception>(() => queue.Dequeue());
        }
    }
}