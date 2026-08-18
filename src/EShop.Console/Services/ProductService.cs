using EShop.Console.Dtos;
using EShop.Console.Shared;

namespace EShop.Console.Services;

public class ProductService : IProductService
{
    public IEnumerable<ProductDto> GetProducts()
    {
        var startIndex = 0;
        var endIndex = DummyData.Products.Count;
        
        System.Console.WriteLine("Start iteration.");
        while (startIndex < endIndex)
        {
            yield return DummyData.Products[startIndex].MapToDto();
            startIndex++;
        }
        System.Console.WriteLine("End iteration");
    }
}

