namespace Array;

public class Array
{
    // Object
    // Type : Array
    private Object[] _InnerArray; // null
    private int index = 0;

    public int Count =>  index;  // Dizi kaç eleman var?
    public int Capacity => _InnerArray.Length;


    public Array()
    {
        _InnerArray = new Object[4]; // Block allocation
    }

    public void Add(Object item)
    {
        if (index == _InnerArray.Length)
        {
            DoubleArray(_InnerArray);
        }

        _InnerArray[index] = item;
        index++;
    }

    private void DoubleArray(object[] array)
    {
        var newArray = new Object[array.Length * 2];
        System.Array.Copy(array, newArray, array.Length);
        _InnerArray = newArray;
    }

    public Object GetItem(int position)
    {
        return _InnerArray[position];
    }
}