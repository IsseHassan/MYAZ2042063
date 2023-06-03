using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTests
{
    public class ArrayProblemTests
    {
        [Fact]
        public void Array_Concate_Test()
        {
            // Arrange
            var arrayProblem = new Array.ArrayProblem();
            arrayProblem.Add(1);
            arrayProblem.Add(2);
            arrayProblem.Add(3);

            //Act
            arrayProblem.Concate(new object[] { 4, 5 });

            //Assert
            Assert.Equal(5, arrayProblem.Count); 
            var expectedArray = new object[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < expectedArray.Length; i++)
            {
                Assert.Equal(expectedArray[i], arrayProblem.GetItem(i)); 
            }
        }
    }
}
