using PriorityQueue;

namespace PriorityQueueTests
{
    public class MaxHeapTests
    {
        private MaxHeap<int> maxHeap { get; set; }
        public MaxHeapTests()
        {
            maxHeap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 21, 18, 21, 11});
        }
        [Fact]
        public void Count_Test()
        {
            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18  21
            //  /
            // 11

            var count = maxHeap.Count;
            Assert.Equal(count, 8);

        }
        [Fact]
        public void GetEnumerator_Test()
        {
            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18   21
            //  /
            // 11

            // Act
            Assert.Collection(maxHeap,
                item => Assert.Equal(54, item),
                item => Assert.Equal(45, item),
                item => Assert.Equal(36, item),
                item => Assert.Equal(27, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(18, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(11, item));
        }
    }
}