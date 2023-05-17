using TreesEmplementation;
using System.Collections.Generic;
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
            bst.Insert(23);

            // Assert
            Assert.Equal(23, bst.Root.Value);
            Assert.True(23 == bst.Root.Value);
        }
        [Fact]
        public void Insert_test()
        {
            BST<int> bst = new BST<int>(new List<int> { 23, 12, 44, 6, 16, 32, 55, 5, 56, 61 });
        }

        [Fact]
        public void TestPreOrderRecursive()
        {
            BST<int> bst = new BST<int>();
            bst.Insert(23);
            bst.Insert(12);
            bst.Insert(44);
            bst.Insert(6);
            bst.Insert(16);
            bst.Insert(32);
            bst.Insert(55);
            bst.Insert(5);
            bst.Insert(56);
            bst.Insert(61);
            string output = "";
            //Console.Write(output);

            using (StringWriter sw = new StringWriter())
            {
                // Redirect Console.Write to StringWriter
                Console.SetOut(sw);

                // Act
                bst.PreOrderRecursive(bst.Root);

                // Get the captured output
                //string output = sw.ToString().Trim();

                // Assert
                Assert.Equal("23 12 6 5 16 44 32 55 56 61", output);
            }
        }

        [Fact]
        public void TestCountLeaves()
        {
            
            BST<int> bst = new BST<int>();
            bst.Insert(23);
            bst.Insert(12);
            bst.Insert(44);
            bst.Insert(6);
            bst.Insert(16);
            bst.Insert(32);
            bst.Insert(55);
            bst.Insert(5);
            bst.Insert(56);
            bst.Insert(61);

            
            int count = bst.CountLeaves(bst.Root);

            
            Assert.Equal(4,count);

        }
    }
}