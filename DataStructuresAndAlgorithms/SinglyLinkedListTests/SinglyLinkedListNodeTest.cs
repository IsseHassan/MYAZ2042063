
using LinkedList.Singly;

namespace SinglyLinkedListTests
{
    public class SinglyLinkedListNodeTest
    {
        [Fact]
        public void SinglyLinkedListNode_Test()
        {
            // arrange 
            var node1 = new SinglyLinkedListNode<int>()
            {
                Value = 10
            };

            var node2 = new SinglyLinkedListNode<int>(20);

            // act
            node1.Next = node2;


            // assert
            Assert.Equal(node1.Next, node2);
            Assert.Equal(node1.Value, 10);
            Assert.Equal(node1.Next.Value, 20);
            Assert.True(node1.Next.Value == node2.Value);
        }
    }
}