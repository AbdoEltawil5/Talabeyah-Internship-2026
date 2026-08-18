using EShop.Console.Entities;
using EShop.Console.Shared;

namespace EShop.Console.Extensions;

public static class TotalPriceExtension
{
    public static Money TotalPrice(this Cart cart)
    {
        var totalPrice = cart.Items.Sum(ci => ci.Price.Amount * ci.Quantity);
        var currency = cart.Items.First().Price.Currency;
        return new Money(totalPrice, currency);
    }
}