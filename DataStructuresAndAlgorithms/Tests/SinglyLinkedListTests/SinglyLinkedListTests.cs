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
        /// <summary>
        /// Week 4 - AddAfter Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_AddAfter_Test()
        {
            var LinkedList = new SinglyLinkedList<char>();
            LinkedList.AddFirst('a');
            LinkedList.AddFirst('b');
            LinkedList.AddFirst('c');

            LinkedList.AddAfter(LinkedList.Head.Next, 'x');  //c b [x]  a

            //Assert

            Assert.Equal(LinkedList.Head.Value, 'c');
            Assert.Equal(LinkedList.Head.Next.Next.Value, 'x');
        }
        /// <summary>
        /// Week 4 - AddAfter Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_AddAfter_Throw_ExceptionTest()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            var node = new SinglyLinkedListNode<char>('y');

            Assert.Throws<Exception>(() => linkedList.AddAfter(node, 'x'));
        }
        /// <summary>
        /// Week 4 - RemoveFirst Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            var item = linkedList.RemoveFirst();//b a

            Assert.Equal(item, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'a');
        }
        /// <summary>
        /// Week 4 - RemoveFirst Tek Eleman Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_One_Item_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');

            var item = linkedList.RemoveFirst();
            Assert.Equal(item, 'a');
            Assert.True(linkedList.Head== null);
        }
        /// <summary>
        /// Week 4 - RemoveFirst Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Exception_Test()
        {
            var linkedList = new SinglyLinkedList<char>();           

            Assert.Throws<Exception>(()=> linkedList.RemoveFirst());
        }

        // <summary>
        /// Week 4 - RemoveLast Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveLast_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            var item1 = linkedList.RemoveLast();
            var item2 = linkedList.RemoveLast();
            var item3 = linkedList.RemoveLast();

            Assert.True(linkedList.Head is null);
            Assert.Equal(item1, 'a');
            Assert.Equal(item3, 'c');

        }
        // <summary>
        /// Week 4 - RemoveLast Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveLast_Exception_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
           
            Assert.Throws<Exception>(()=> linkedList.RemoveLast());
        }
        [Fact]
        public void SinglyLinkedList_Remove_LastItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('a');

            var item = linkedList.Remove(node);
           
            Assert.Equal(item, 'a');
        }
        [Fact]
        public void SinglyLinkedList_Remove_MiddleItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('b');
            var item = linkedList.Remove(node);
            Assert.Equal(item, 'b');
        }
        [Fact]
        public void SinglyLinkedList_Remove_FirstItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('c');
            var item = linkedList.Remove(node);
            
            Assert.Equal('c', item);
        }

        [Fact]
        public void SinglyLinkedList_Remove_Exception_Test()
        {
            var linkedList = new SinglyLinkedList<char>();

            var node = new SinglyLinkedListNode<char>('b');
            Assert.Throws<Exception>(()=> linkedList.Remove(node));
        }
        [Fact]
        public void SinglyLinkedList_Remove_Exception2_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('x');
            Assert.Throws<Exception>(() => linkedList.Remove(node));
        }
        [Fact]
        public void SinglyLinkedList_Get_Enumerator_Test()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            
            Assert.Collection<int>(list,
                item => Assert.Equal(10, item),
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 30));
        }
        [Fact]
        public void SinglyLinkedList_Constructor_For_Char_Array_Input_Test()
        {
            var list = new SinglyLinkedList<char>("meltem".ToArray());

            // m e t l e m 
            Assert.Collection<char>(list,
                item => Assert.Equal('m', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('t', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('m', item));
        }
        [Fact]
        public void SinglyLinkedList_Constructor_For_List_Input_Test()
        {
            var list = new SinglyLinkedList<int>(new List<int>() { 5,10,15,20});

            // 20 15 10 5

            Assert.Collection<int>(list,
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 15),
                item => Assert.Equal(item, 10),
                item => Assert.Equal(item, 5));
        }
        [Fact]
        public void SinglyLinkedList_Constructor_For_SortedSet_Input_Test()
        {
            var list = new SinglyLinkedList<int>(new SortedSet<int>() { 23, 16, 23, 55, 61, 23, 44 });



            //61 55 44 23 16
            Assert.Collection<int>(list,
                item => Assert.Equal(61, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(44, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(16, item));
        }
    }
}
