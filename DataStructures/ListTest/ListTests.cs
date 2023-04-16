
namespace ListTests
{
    public class ListTests
    {
        /// <summary>
        /// Week 3 - Add Test
        /// </summary>
        [Fact]
        public void List_Add_Test()
        {
            var list= new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            int Capacity = list.Capacity;
            Assert.Equal(8, Capacity);
            Assert.Collection<int>(list, 
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item), 
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                 item => Assert.Equal(5, item));

        }
        [Fact]
        public void List_AddRange_Test()
        {
           var list = new List<int>();
            list.AddRange(new[] { 1, 2, 3, 4, 5, 6 });

            //Assert
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item));
        }
        [Fact]
        public void List_Remove_Test()
        {
            var list = new List<int>();
            list.AddRange(new[] { 1, 2, 3, 4, 5 });
            bool test1 = list.Remove(5);
            bool _ = list.Remove(3);
            bool test2 = list.Remove(7);


            int capacity = list.Capacity;
            Assert.Equal(5, capacity);
            Assert.True(test1);
            Assert.True(!test2);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                 item => Assert.Equal(2, item),
                  item => Assert.Equal(4, item));
        }
        [Fact]
        public void List_RemoveAt_Test()
        {
            var list = new List<string>();
            list.AddRange(new[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" });
            list.RemoveAt(2);

            Assert.Collection<string>(list,
                item => Assert.Equal("Mehmet",item),
                item => Assert.Equal("Ahmet", item),
                item => Assert.Equal("Ali", item),
                item => Assert.Equal("Naz", item));
        }
        [Fact]
        public void List_InterSect_Test() 
        {
             var list = new List<string>() { "Mehmet", "Ali", "Nursel", "Mert", "Emir" }; 
            string[] strinList   = new string[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" };

            string[] Interset = list.Intersect(strinList).ToArray();
            Assert.Equal("Mehmet", Interset[0]);
            Assert.Equal("Ali", Interset[1]);
        }
        [Fact]
        public void List_Union_Test()
        {
            var list = new List<string>() { "Mehmet", "Ali", "Nursel", "Mert", "Emir" };
            string[] stringList = new string[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" };

            // Act
            string[] interList = list.Union(stringList).ToArray();
            // Assert
            Assert.Equal("Mehmet", interList[0]);
            Assert.Equal("Ali", interList[1]);
            Assert.Equal("Nursel", interList[2]);
            Assert.Equal("Mert", interList[3]);
            Assert.Equal("Emir", interList[4]);
            Assert.Equal("Ahmet", interList[5]);
            Assert.Equal("Tekin", interList[6]);
            Assert.Equal("Naz", interList[7]);
        }
        [Fact]
        public void _List_Except_Test()
        {
            
            var list = new List<string>() { "Mehmet", "Ahmet", "Nursel", "Ali", "Mert" };
            string[] stringList = new string[] { "Mehmet", "Ali", "Nursel", "Mert", "Emir" };

            // Act
            string[] interList = list.Except(stringList).ToArray();
            //Assert
            Assert.Equal("Ahmet", interList[0]);
        }
    }
}