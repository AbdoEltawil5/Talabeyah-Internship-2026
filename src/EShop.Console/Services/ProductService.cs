using EShop.Console.Entities;

namespace EShop.Console.Services;

public class ProductService : IProductService
{
    private List<Product> _products = new List<Product>();
    public IEnumerable<Product> GetProducts()
    {
        GenerateProductsData();
        System.Console.WriteLine("Welcome to GetProducts()");
        for (int i = 0; i < _products.Count; i++)
        {
            System.Console.WriteLine("Product Number "+ (i+1));
            yield return _products[i];
        }
    }

    private void GenerateProductsData()
    {
        _products.Add(new Product(Guid.NewGuid(), "pepsi", "bla bla bla", new Money(54, Currency.EGP), 77, new Category(Guid.NewGuid(), "drinks", Guid.NewGuid())));
        _products.Add(new Product(Guid.NewGuid(), "shibsy", "bla bla bla", new Money(54, Currency.EGP), 77, new Category(Guid.NewGuid(), "shibsy", Guid.NewGuid())));
        _products.Add(new Product(Guid.NewGuid(), "leban", "bla bla bla", new Money(54, Currency.EGP), 77, new Category(Guid.NewGuid(), "leban", Guid.NewGuid())));
        _products.Add(new Product(Guid.NewGuid(), "pesil", "bla bla bla", new Money(54, Currency.EGP), 77, new Category(Guid.NewGuid(), "cleaning", Guid.NewGuid())));
    }
}