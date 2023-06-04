using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public partial class ArrayProblem: Array
    {
        public ArrayProblem():base()
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
