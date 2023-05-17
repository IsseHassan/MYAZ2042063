
using DataStructues.Trees.BinaryTree;
using Trees.BinaryTree.BinarySearchTree;

namespace TreeTests
{
    public class BinarySearchTreeTests
    {
        private BST<int> bst { get; set; }
        public BinarySearchTreeTests()
        {
            bst= new BST<int>();
        }

        [Fact]
        public void Add_Roo_Test()
        {
            bst.Add(23);

            Assert.Equal(23, bst.Root.Value);
            Assert.False(!(23 == bst.Root.Value));
        }
        [Fact]
        public void Adding_with_IEnumerable_Constructor()
        {
            // Act
            var bst = new BST<int>(new List<int> { 23, 16, 44, 3, 22, 99, 37 });

            // Assert
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
                item => Assert.Equal(3, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(22, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(37, item),
                item => Assert.Equal(44, item),
                item => Assert.Equal(99, item));
        }

    }
}