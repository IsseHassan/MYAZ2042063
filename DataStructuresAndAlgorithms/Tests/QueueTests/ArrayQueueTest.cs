using Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTests
{
    public class ArrayQueueTest
    {
        [Fact]
        public void ArrayQueue_Enqueue_Test()
        {
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'}

            queue.Enqueue('A');

            Assert.Equal(7, queue.Count);
        }
        [Fact]
        public void ArrayQueue_Dequeue_Test()
        {
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'};

            var item = queue.Dequeue();

            Assert.Equal(item, 'M');
            Assert.Equal(5, queue.Count);
        }
        [Fact]
        public void ArrayQueue_Dequeue_Exception_Test()
        {
            var queue = new ArrayQueue<char>();

            Assert.Throws<Exception>(() => queue.Dequeue());
        }
        [Fact]
        public void ArrayQueue_Peek_Test()
        {
            // Arrange
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'}

            var item = queue.Peek();

            Assert.Equal(6, queue.Count);
            Assert.True(item == 'M');
        }
    }
}
