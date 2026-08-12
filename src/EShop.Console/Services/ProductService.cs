using EShop.Console.Entities;

namespace EShop.Console.Services;

public class ProductService
{
    private readonly List<Product> _products;

    public ProductService(List<Product> products)
    {
        _products = products ?? throw new ArgumentNullException(nameof(products));
    }
    public IEnumerable<Product> GetProducts()
    {
        System.Console.WriteLine("Iterator Started");
        
        foreach (var product in _products)
        {
            System.Console.WriteLine($"Yield :{product.Name}");
            yield return product;
        }

        System.Console.WriteLine("Iterator Ended");
    }
}