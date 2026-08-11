using EShop.Console.Entities;

namespace EShop.Console.Repositories.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product? GetProduct(Guid id);
}