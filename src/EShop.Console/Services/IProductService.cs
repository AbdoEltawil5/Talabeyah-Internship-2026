using EShop.Console.Dtos;

namespace EShop.Console.Services;

public interface IProductService
{
    IEnumerable<ProductDto> GetProducts(int pageNumber = 1, int pageSize = 5);
}