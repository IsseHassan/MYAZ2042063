using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests
{
    public class InsertionSortTests
    {
        private int[] _array;
        public InsertionSortTests()
        {
            _array = new int []{ 10, 20, 50, 30, 40 };
        }
        [Fact]
        public void InsertionSort_Test()
        {
            InsertionSort.Sort(_array);

            Assert.Collection(_array,
                item => Assert.Equal(10, _array[0]),
                item => Assert.Equal(20, _array[1]),
                item => Assert.Equal(30, _array[2]),
                item => Assert.Equal(40, _array[3]),
                item => Assert.Equal(50, _array[4]));
        }
    }
}
