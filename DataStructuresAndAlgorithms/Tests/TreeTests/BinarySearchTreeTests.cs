using Trees.BinaryTree.BinarySearchTree;

namespace TreeTests
{
    public class BinarySearchTreeTests
    {
        private BTS<int> bst { get; set; }
        public BinarySearchTreeTests()
        {
            bst= new BTS<int>();
        }
        [Fact]
        public void Add_Root_Test()
        {
            bst.Add(23);

            Assert.Equal(23, bst.Root.Value);
            Assert.True(23 == bst.Root.Value);
            

        }
    }
}