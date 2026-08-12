using EShop.Console.Entities;

namespace EShop.Console.Services;

public interface IProductService
{
    public IEnumerable<Product> GetProducts();
}