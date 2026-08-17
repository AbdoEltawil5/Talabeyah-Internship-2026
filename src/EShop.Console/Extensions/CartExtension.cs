using EShop.Console.Entities;
using EShop.Console.ValueObjects;

namespace EShop.Console.Extensions;

public static class CartExtension
{
    public static Money TotalPrice(this Cart cart, List<Product> products)
    {
        var total = new Money(0m);

        foreach (var item in cart.Items)
        {
            var product = products.FirstOrDefault(p => p.Id == item.ProductId);
            if (product is null)
                throw new InvalidOperationException($"Product {item.ProductId} not found.");

            total = total + product.Price * item.Quantity;
        }

        return total;
    }
}
