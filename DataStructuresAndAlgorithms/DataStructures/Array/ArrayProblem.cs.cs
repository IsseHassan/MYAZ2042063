using Array;

namespace Array
{
    partial class ArrayProblem
    {
        public  Array array { get; set; }
        public ArrayProblem()
        {
            array = new Array(default);
        }
      
        /// <summary>
        /// Concate fonksiyonu parametre olarak aldığı array ifadesini 
        /// mevcut dizi yapısı ile birleştirmelidir. 
        /// Örneğin: Array tipindeki numbers = [1,2,3] tanımlansın.
        /// numbers.Concate([4,5]) şeklinde bir komut verildiğinde 
        /// Çıktı : [1,2,3,4,5] olmalıdır. 
        /// </summary>
        /// <param name="array">Birleştirilecek diziyi temsil eder.</param>
        public void Concate(object[] array)
        {

        }
    }
    
}
