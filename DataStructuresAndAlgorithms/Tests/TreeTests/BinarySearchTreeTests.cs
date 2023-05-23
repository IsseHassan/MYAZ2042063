using DataStructures.Trees.BinaryTree;
using Trees.BinaryTree.BinarySearchTree;


namespace TreeTests
{
    public class BinarySearchTreeTests
    {
        private BST<int> bst { get; set; }
        public BinarySearchTreeTests()
        {
            bst = new BST<int>();
        }

        [Fact]
        public void Add_Root_Test()
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

            //      23 
            //      / \
            //    16    44
            //   / \    / \
            //  3  22  37 99


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

        [Fact]
        public void Findmin_Test()
        {
            var bst = new BST<int>(new List<int> { 23, 16, 44, 3, 22, 99, 37 });

            //      23 
            //      / \
            //    16    44
            //   / \    / \
            //  3  22  37 99

            var min = bst.FindMin(bst.Root);

            Assert.Equal(3, min);
        }
        [Fact]
        public void Findmax_Test()
        {
            var bst = new BST<int>(new List<int> { 23, 16, 44, 3, 22, 99, 37 });

            //      23 
            //      / \
            //    16    44
            //   / \    / \
            //  3  22  37 99

            var max = bst.FindMax();
            Assert.Equal(99, max);
        }

        [Fact]
        public void Find()
        {
            var bst = new BST<int>(new List<int> { 23, 16, 44, 3, 22, 99, 37 });

            //      23 
            //      / \
            //    16    44
            //   / \    / \
            //  3  22  37 99

            var node = bst.Find(22);

            Assert.Equal(node, bst.Root.Left.Right);
        }
        [Fact]
        public void Revemo_A_Leaf()
        {
            var bst = new BST<int>(new List<int> { 60,40, 70, 20,45,65,85 });
            //      60 
            //      / \
            //    40    70
            //   / \    / \
            // [20] 45  65 85


            //      60 
            //      / \
            //    40    70
            //     \    / \
            //     45  65 85

           var node = bst.Remove(bst.Root, 20);
            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);

            Assert.Collection(list,
                item => Assert.Equal(40, item),
                item => Assert.Equal(45, item),
                item => Assert.Equal(60, item),
                item => Assert.Equal(65, item),
                item => Assert.Equal(70, item),
                item => Assert.Equal(85, item));
        }

        [Fact]
        public void Revemo_A_Node_With_One_Child()
        {
            var bst = new BST<int>(new List<int> { 60, 40, 70, 20, 45, 65, 85 });
            //      60 
            //      / \
            //    40    70
            //   / \    / \
            //  20 45  65 85

            //      60 
            //      / \
            //    40    70
            //     \    / \
            //      45  65 85

            var node = bst.Remove(bst.Root, 20);

            node = bst.Remove(bst.Root, 40);

            //      60 
            //      / \
            //    45    70
            //          / \
            //         65 85

            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
                item => Assert.Equal(45, item),
                item => Assert.Equal(60, item),
                item => Assert.Equal(65, item),
                item => Assert.Equal(70, item),
                item => Assert.Equal(85, item));
        }

        [Fact]
        public void Revemo_A_Node_With_Two_Child()
        {
            var bst = new BST<int>(new List<int> { 60, 40, 70, 20, 45, 61, 85 });
            //      60 
            //      / \
            //    40    70
            //   / \    / \
            //  20 45  61 85

            //      60 
            //      / \
            //    40    70
            //     \    / \
            //      45  61 85


            var node = bst.Remove(bst.Root, 20);
            node = bst.Remove(bst.Root, 40);

            //      60 
            //      / \
            //    45    70
            //          / \
            //         61 85

            node = bst.Remove(bst.Root, 60);

            //      61 
            //      / \
            //    45    70
            //           \
            //            85

            var list = BinaryTree<int>.InOrderIterationTraverse(bst.Root);
            Assert.Collection(list,
                item => Assert.Equal(45, item),
                item => Assert.Equal(61, item),
                item => Assert.Equal(70, item),
                item => Assert.Equal(85, item));

            Assert.Equal(61, bst.Root.Value);
        }
    }

}