using EShop.Console.Entities;

namespace EShop.Console.Services.Interfaces;

public interface IProductService
{
    List<Product> GetProducts();
    Product? GetProduct(Guid id);
}