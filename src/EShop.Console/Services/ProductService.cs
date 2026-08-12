using EShop.Console.Dtos;
using EShop.Console.Shared;

namespace EShop.Console.Services;

public class ProductService : IProductService
{
    public IEnumerable<ProductDto> GetProducts(int pageNumber = 1, int pageSize = 5)
    {
        if (pageNumber < 1)
            pageNumber = 1;
        
        if (pageSize < 1)
            pageSize = 5;
        
        var startIndex = (pageNumber - 1) * pageSize;
        var endIndex = pageNumber * pageSize;
        System.Console.WriteLine("Start iteration.");
        while (startIndex < endIndex)
        {
            yield return DummyData.Products[startIndex].MapToDto();
            startIndex++;
        }
        System.Console.WriteLine("End iteration");
    }
}

