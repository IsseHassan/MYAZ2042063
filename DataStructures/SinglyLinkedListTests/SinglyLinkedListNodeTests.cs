using LinkedList.Singly;

namespace SinglyLinkedListTests
{
    public class SinglyLinkedListNodeTests
    {
        [Fact]
        public void SinglyLinkedListNode_Test() 
        {
            var node1 = new SinglyLinkedListNode<int>()
            {
                Value= 10,
            };
            var node2 = new SinglyLinkedListNode<int>(20);

            node1.Next= node2;
            Assert.Equal(node1.Next, node2);
            Assert.Equal(node1.Value, 10);
            Assert.Equal(node1.Next.Value, 20);
            Assert.True(node1.Next.Value == node2.Value);

        }
    }
}