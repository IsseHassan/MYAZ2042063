namespace BHeapAppWithProducts
{
    public class Product : IComparable
    {
        public int id { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public int CompareTo(object? obj)
        {
            Product product= obj as Product;

            return this.price.CompareTo(product.price);
        }
    }
}
