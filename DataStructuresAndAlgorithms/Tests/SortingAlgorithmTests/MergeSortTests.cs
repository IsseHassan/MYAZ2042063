using SortingAlgorithm;
namespace SortingAlgorithmTests
{
    public class MergeSortTests
    {
        private int[] _array;
        public MergeSortTests()
        {
            _array= new int[] { 10, 20, 50, 30, 40 };
        }
        [Fact]
        public void MergeSort_Test()
        {
            MergeSort.Sort(_array);

            Assert.Equal(10, _array[0]);
            Assert.Equal(20, _array[1]);
            Assert.Equal(30, _array[2]);
            Assert.Equal(40, _array[3]);
            Assert.Equal(50, _array[4]);
        }
    }
}
