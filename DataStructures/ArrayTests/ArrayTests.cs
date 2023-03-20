namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(3, count);
            Assert.Equal(4, array.Capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);
        }

        [Fact]
        public void Array_GetItem_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            var item = array.GetItem(1);

            // Assert
            Assert.Equal(item, "Mehmet");
        }
        [Fact]
        public void Arrry_Find_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);

            // Act
            int result = array.Find(2);

            // Assert
            Assert.Equal(result, 1);
        }

        [Fact]
        public void Array_GetEnumerator()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            Assert.Equal(result, "AhmetMehmetCan");

        }

        [Fact]
        public void Array_Contructor_Test()
        {
            // Arrange
            var array = new Array.Array(36, 23, 55, 44, 61);

            // Act
            var result = array.Capacity; // 5

            var result2 = String.Empty;
            foreach (var item in array)
            {
                result2 = string.Concat(result2, item);
            }

            // Assert
            Assert.Equal(5, result);
            Assert.Equal("3623554461", result2);
        }

        [Fact]
        public void Array_SetItem_Test()
        {
            // Arrange : Düzenleme
            var numbers = new Array.Array(1, 3, 5, 7);

            // Act : Eylem
            numbers.SetItem(2, 55);

            // Assert : İddia
            Assert.Equal(55, numbers.GetItem(2));
            Assert.True(numbers.GetItem(2).Equals(55));
        }
    }
}