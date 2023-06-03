using LinkedList.Doubly;

namespace DoublyLinkedListTests
{
    public class DoublyLinkedListNodeTest
    {
        [Fact]
        public void DbNode_Test()
        {
            var node = new DbNode<int>();

            //act
            node.Value = 1;
            node.Next = new DbNode<int> { Value = 2 };//2
            node.Next.prev = node;
            node.Next.Next = new DbNode<int> { Value = 3 };
            node.Next.Next.prev = node.Next;

            //Asssert
            Assert.Equal(1,node.Value);
            Assert.Equal(2, node.Next.Value);
            Assert.Equal(3, node.Next.Next.Value);
            Assert.True(node.Next.Next.prev== node.Next);

        }
        [Fact]
        public void DbNode_Test2()
        {
            var node = new DbNode<char>('a');
            node.Next = new DbNode<char> ('b');
            node.Next.prev = node;
            node.Next.Next = new DbNode<char>('c');
            node.Next.Next.prev = node.Next;

            //Assert
            Assert.Equal('a', node.Value);
            Assert.Equal('b', node.Next.Value);
            Assert.Equal('c', node.Next.Next.Value);
            Assert.True(node == node.Next.prev);
            Assert.False (!(node.Next.Next.prev == node.Next));
           
            

        }
    }
}