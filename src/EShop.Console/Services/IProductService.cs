using EShop.Console.Dtos;

namespace EShop.Console.Services;

public interface IProductService
{
    IEnumerable<ProductDto> GetProducts();
}