using LinkedList.Singly;    
namespace SinglyLinkedListTests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void SinglyLinkedList_AddFirst_Test()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>();

            // Act
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            // Assert
            Assert.Equal(linkedList.Head.ToString(), "30");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 10);

        }
        [Fact]
        public void SinglyLinkedList_AddLast_Test()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>();

            // Act
            linkedList.AddLast(10);     // 10 
            linkedList.AddLast(20);     // 10 -> 20 
            linkedList.AddLast(30);     // 10 -> 20 -> 30

            // Assert
            Assert.Equal(linkedList.Head.ToString(), "10");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 30);

        }
        [Fact]
        public void SinglyLinkedList_AddFirst_Test_2()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // act
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'b');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'a');
        }
        [Fact]
        public void SinglyLinkedList_AddLast_Test_2()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // act
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a
            linkedList.AddLast('x');    // c - b - a - x
            linkedList.AddLast('y');    // c - b - a - x - y
            linkedList.AddLast('z');    // c - b - a - x - y -z

            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'b');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'a');
            Assert.Equal(linkedList.Head.Next.Next.Next.Value, 'x');
            Assert.Equal(linkedList.Head.Next.Next.Next.Next.Value, 'y');
            Assert.Equal(linkedList.Head.Next.Next.Next.Next.Next.Value, 'z');
        }

        [Fact]
        public void SinglyLinkedList_AddBefore_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            linkedList.AddBefore(linkedList.Head.Next, 'x');  // c [x] b a


            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'x');

        }

        [Fact]
        public void SinglyLinkedList_AddBefore_Throw_ExceptionTest()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('y');

            // assert
            Assert.Throws<Exception>(() => linkedList.AddBefore(node, 'x'));
        }

    }
}
