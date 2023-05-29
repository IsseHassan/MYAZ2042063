using PriorityQueue;

namespace PriorityQueueTests
{
    public class MaxHeapTests
    {
        private MaxHeap<int> maxHeap { get; set; }
        public MaxHeapTests()
        {
            maxHeap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 21, 18, 21, 11 });
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

        [Theory]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(15)]
        public void Add_Test(int value)
        {
            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18   21
            //  / \
            // 11 [value]

            maxHeap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 21, 18, 21, 11, value });
            Assert.Collection(maxHeap,
                item => Assert.Equal(54, item),
                item => Assert.Equal(45, item),
                item => Assert.Equal(36, item),
                item => Assert.Equal(27, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(18, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(11, item),
                item => Assert.Equal(value, item));

            Assert.Equal(value, maxHeap.Array.GetValue(maxHeap.Count - 1));
        }

        [Theory]
        [InlineData(90)]
        [InlineData(91)]
        [InlineData(92)]
        [InlineData(93)]
        [InlineData(94)]
        [InlineData(95)]
        public void HeapifyUp_Test(int value)
        {
            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18   21
            //  / \
            // 11 [value]


            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //  [v]  21  18   21
            //  / \
            // 11 27


            //        54
            //       /   \
            //     [v]     36
            //    / \     /  \
            //   45  21  18   21
            //  / \
            // 11 27


            //        [v]
            //       /   \
            //     [54]     36
            //    / \     /  \
            //   45  21  18   21
            //  / \
            // 11 27

            maxHeap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 21, 18, 21, 11, value });

            Assert.Collection(maxHeap,
                item => Assert.Equal(value, item),
                item => Assert.Equal(54, item),
                item => Assert.Equal(36, item),
                item => Assert.Equal(45, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(18, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(11, item),
                item => Assert.Equal(27, item));

            Assert.Equal(value, maxHeap.Array.GetValue(0));
        }

        [Fact]
        public void Remove_Test()
        {
            //        54
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18   21
            //  / 
            // 11 

            //        [11]
            //       /   \
            //     45     36
            //    / \     /  \
            //   27  21  18   21

            //        [45]
            //       /   \
            //    [11]   36
            //    / \     /  \
            //   27  21  18   21


            //        [45]
            //       /   \
            //    [27]   36
            //    / \     /  \
            // [11]  21  18   21

            maxHeap = new MaxHeap<int>(new int[] { 54,45,36,27,21,18,21,11});
            var removedItem = maxHeap.DeleteMinMax();

            Assert.Collection(maxHeap,
                item => Assert.Equal(45, item),
                item => Assert.Equal(27, item),
                item => Assert.Equal(36, item),
                item => Assert.Equal(11, item),
                item => Assert.Equal(21, item),
                item => Assert.Equal(18, item),
                item => Assert.Equal(21, item));

            Assert.Equal(removedItem, 54);
        }

        [Fact]
        public void ForEach_Test()
        {
           var  maxHeap = new MaxHeap<int>(new int[] {30,50,42,66,10,16,5 });

            //        66
            //       /   \
            //      50    42
            //    / \     /  \
            //   30 10   16  5

            Assert.Collection(maxHeap,
                item => Assert.Equal(66, item),
                item => Assert.Equal(50, item),
                item => Assert.Equal(42, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(10, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(5, item));

        }
        [Fact]
        public void ItemRemove_Test()
        {
            var maxHeap = new MaxHeap<int>(new int[] {30, 50, 42, 66, 10, 16, 5 });
            var result = maxHeap.DeleteMinMax();

            //        66
            //       /   \
            //      50    42
            //    / \     /  \
            //   30 10   16  5


            //        5
            //       /   \
            //      50    42
            //    / \     /  
            //   30 10    16


            //        50
            //       /   \
            //     30     42
            //    / \     /  
            //   5  10    16
            Assert.Collection(maxHeap,
                item => Assert.Equal(50, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(42, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(10, item),
                item => Assert.Equal(16, item));

            Assert.Equal(result, 66);
       }
        [Fact]
        public void HeapSort_Test()
        {
            var maxHeap = new MaxHeap<int>(new int[] { 30, 50, 42, 66, 10, 16, 5 });
            var list = new List<int>();

            foreach (var item in maxHeap)
            {
                list.Add(maxHeap.DeleteMinMax());
            }

            Assert.Collection(list,
                item => Assert.Equal(66, item),
                item => Assert.Equal(50, item),
                item => Assert.Equal(42, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(10, item),
                item => Assert.Equal(5, item));
        }
    }
}