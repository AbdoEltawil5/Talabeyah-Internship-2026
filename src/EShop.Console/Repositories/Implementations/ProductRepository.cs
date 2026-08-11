using EShop.Console.Entities;
using EShop.Console.Repositories.Interfaces;

namespace EShop.Console.Repositories.Implementations;

public class ProductRepository : IProductRepository
{
    private List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>()
        {
            new Product("IPhone X", 10000, new Guid("7E89F160-38C0-4F4B-8E4F-E926FB97D8CA"), 50),
            new Product("Lenovo Legion Laptop", 50000, new Guid("9AB11ADE-FCD4-43DC-BEFD-1AB5E6ABE8AB"), 20),
            new Product("Charger Type-C", 300, new Guid("2310C208-A107-4594-8E6F-5A13BB7029D2"), 50),
            new Product("HP Laptop", 28000, new Guid("9AB11ADE-FCD4-43DC-BEFD-1AB5E6ABE8AB"), 17),
            new Product("Samsung A70", 12000, new Guid("7E89F160-38C0-4F4B-8E4F-E926FB97D8CA"), 120)
        };
    }
    public IEnumerable<Product> GetAll()
    {
        return _products;    
    }

    public Product? GetProduct(Guid id)
    {
        var productIndex = _products.FindIndex(p => p.Id == id);
        if (productIndex != -1)
            return _products[productIndex];
        return null;
    }
}