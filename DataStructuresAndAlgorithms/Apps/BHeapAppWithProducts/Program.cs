using BHeapAppWithProducts;
using PriorityQueue;
using System.Text.Json;

Console.WriteLine("Hello, World!");
var products = GetProducts();

foreach (var item in products)
{
    Console.WriteLine($"{item.id,-3}{item.productName,-5}{item.price,5}");
}
Console.WriteLine("------------------------------------");
var ProductList = GetTopProducts(5);
foreach (var item in ProductList)
{
    Console.WriteLine($"{item.id,-3}{item.productName,-5}{item.price,5}");
}
/* Bu metod Products.json dosyasından ürünleri 
 * okuyarak size MaxHeap<Product> türünde bir nesne vermelidir.
*/
MaxHeap<Product> GetProducts()
{

    string ProductsJson  = File.ReadAllText(@"D:\MYAZ2042063\DataStructuresAndAlgorithms\Apps\BHeapAppWithProducts\Products.json");
    var list = JsonSerializer.Deserialize<Dictionary<string, List<Product>>>(ProductsJson);
   
    return new MaxHeap<Product>(list["Products"]);
    

    
}

// n sayısı kadar en pahalı ürünleri veren metot
Product[] GetTopProducts(int n)
{
    Product[] ProductList = new Product[n];

    
    for (int i = 0; i < n; i++)
    {
        ProductList[i] = products.DeleteMinMax();
    }

    return ProductList;
}

