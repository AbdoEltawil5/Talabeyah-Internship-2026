using EShop.Console.Entities;

namespace EShop.Console.Abstractions;

public interface IOrderService
{
    public bool OrderProcessing(List<KeyValuePair<Product, int>> productsCount, double discountPercentage);
}