using TreesEmplementation;

namespace TreesEmplementationTests
{
    public class BinarySearchTests
    {
        private BST<int> bst { get; set; }
        public BinarySearchTests()
        {
            bst = new BST<int>();
        }

        [Fact]
        public void Add_Root_Test()
        {
            // Act
            bst.Add(23);

            // Assert
            Assert.Equal(23, bst.Root.Value);
            Assert.True(23 == bst.Root.Value);
        }

        [Fact]
        public void Test_Add()
        {
            int[] values = { 23, 12, 44, 6, 16, 32, 55, 5, 56, 61 };

            foreach (var value in values)
            {
                bst.Add(value);
            }
            //        23
            //      /    \
            //    12     44
            //   / \      / \ 
            //  6   16   32  55
            // /               \
            // 5                56
            //                    \
            //                     61

            Assert.Equal(bst.Root.Value, 23);
            Assert.Equal(bst.Root.Left.Value, 12);
            Assert.Equal(bst.Root.Right.Value, 44);
            Assert.Equal(bst.Root.Left.Left.Value, 6);
            Assert.Equal(bst.Root.Left.Right.Value, 16);
            Assert.Equal(bst.Root.Right.Left.Value, 32);
            Assert.Equal(bst.Root.Right.Right.Value, 55);
            Assert.Equal(bst.Root.Left.Left.Left.Value, 5);
            Assert.Equal(bst.Root.Right.Right.Right.Value, 56);
            Assert.Equal(bst.Root.Right.Right.Right.Right.Value, 61);
        }

        [Fact]
        public void CountLeaves_Test()
        {

            var bst = new BST<int>(new List<int> { 23, 12, 44, 6, 16, 32, 55, 5, 56, 61 });

            int leaves = bst.CountLeaves(bst.Root);
            Assert.Equal(leaves, 4);
        }
        [Fact]
        public void PreOrder_Recursive_Test()
        {

            var bst = new BST<int>(new List<int> { 23, 12, 44, 6, 16, 32, 55, 5, 56, 61 });

            //        23
            //      /    \
            //    12     44
            //   / \      / \ 
            //  6   16   32  55
            // /               \
            // 5                56
            //                    \
            //                     61

            var list = bst.PreOrderRecursive(bst.Root);
            Assert.Collection(list,
                item => Assert.Equal(23, item),
                item => Assert.Equal(12, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(44, item),
                item => Assert.Equal(32, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(56, item),
                item => Assert.Equal(61, item));


            Assert.Equal(list.Count, 10);
        }

        [Fact]
        public void PreOrde_Iterative_Test()
        {
            var bst = new BST<int>(new List<int> { 23, 12, 44, 6, 16, 32, 55, 5, 56, 61 });

            //        23
            //      /    \
            //    12     44
            //   / \      / \ 
            //  6   16   32  55
            // /               \
            // 5                56
            //                    \
            //                     61

            var list = bst.PreOrderIterative(bst.Root);

            Assert.Collection(list,
                item => Assert.Equal(23, item),
                item => Assert.Equal(12, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(44, item),
                item => Assert.Equal(32, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(56, item),
                item => Assert.Equal(61, item));
        }
      
    }
}