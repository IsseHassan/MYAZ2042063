using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests
{
    public partial class SelectionSortTests
    {
        [Fact]
        public void SelectionSort_Test()
        {
            var arr = new char[] { 'a', 'd', 'z', 'c', };
            SelectionSort.Sort(arr);

            Assert.Collection(arr,
                item => Assert.Equal('a', item),
                item => Assert.Equal('c', item),
                item => Assert.Equal('d', item),
                item => Assert.Equal('z', item));
        }    
    }
}
