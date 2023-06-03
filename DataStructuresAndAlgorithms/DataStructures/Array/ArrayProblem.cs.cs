using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace Array
{
    public class ArrayProblem : Array
    {
        /// <summary>
        /// Concate fonksiyonu parametre olarak aldığı array ifadesini 
        /// mevcut dizi yapısı ile birleştirmelidir. 
        /// Örneğin: Array tipindeki numbers = [1,2,3] tanımlansın.
        /// numbers.Concate([4,5]) şeklinde bir komut verildiğinde 
        /// Çıktı : [1,2,3,4,5] olmalıdır. 
        /// </summary>
        /// <param name="array">Birleştirilecek diziyi temsil eder.</param>
        public ArrayProblem() :base() 
        {

        }

        public ArrayProblem(params object[] init) : base(init)
        {
        }
        public void Concate(object[] array)
        {
            int originalLength = Count;
            int concatLength = originalLength + array.Length;
            var newArray = new object[concatLength];

            for (int i = 0; i < originalLength; i++)
            {
                newArray[i] = GetItem(i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                newArray[originalLength + i] = array[i];
            }

            _InnerArray = newArray;
            index = concatLength;

        }
        
    }
}
