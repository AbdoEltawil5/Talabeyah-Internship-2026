using EShop.Console.Entities;
using EShop.Console.Repositories.Interfaces;
using EShop.Console.Services.Interfaces;

namespace EShop.Console.Services.Implementations;

public class ProductService : IProductService 
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public List<Product> GetProducts()
    {
        return _productRepository.GetAll().ToList();
    }

    public Product? GetProduct(Guid id)
    {
        var product = _productRepository.GetProduct(id);
        if (product is not null)
        {
            return product;
        }
        return null;
    }
    
}